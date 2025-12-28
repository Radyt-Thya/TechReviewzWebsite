// Lightweight page translator using MyMemory with localStorage caching.
// Usage: myTranslator.translatePage('es')
// (existing implementation kept, also expose module exports for import())
window.myTranslator = (function () {
    const CACHE_KEY_PREFIX = 'myTranslator:cache:';
    const CACHE_LANG_KEY = 'myTranslator:selectedLang';

    async function translateText(text, lang) {
        if (!text || !lang) return null;
        const cacheKey = CACHE_KEY_PREFIX + lang + ':' + text;
        try {
            const cached = localStorage.getItem(cacheKey);
            if (cached) return cached;
        } catch { /* ignore storage errors */ }

        const apiUrl = `https://api.mymemory.translated.net/get?q=${encodeURIComponent(text)}&langpair=en|${lang}`;
        const resp = await fetch(apiUrl);
        if (!resp.ok) throw new Error('HTTP ' + resp.status);
        const data = await resp.json();
        const translated = data?.responseData?.translatedText ?? null;

        try {
            if (translated) localStorage.setItem(cacheKey, translated);
        } catch { /* ignore storage errors */ }

        return translated;
    }

    function collectTextNodes(root = document.body) {
        const walker = document.createTreeWalker(root, NodeFilter.SHOW_TEXT, {
            acceptNode(node) {
                if (!node.nodeValue) return NodeFilter.FILTER_REJECT;
                const parent = node.parentElement;
                if (!parent) return NodeFilter.FILTER_REJECT;
                const tag = parent.tagName.toLowerCase();
                const ignored = ['script', 'style', 'textarea', 'input', 'pre', 'code', 'svg', 'noscript', 'button', 'option'];
                if (ignored.includes(tag)) return NodeFilter.FILTER_REJECT;
                const text = node.nodeValue.trim();
                if (!text) return NodeFilter.FILTER_REJECT;
                if (text.length < 2) return NodeFilter.FILTER_REJECT;
                return NodeFilter.FILTER_ACCEPT;
            }
        });

        const nodes = [];
        let n;
        while (n = walker.nextNode()) nodes.push(n);
        return nodes;
    }

    async function translatePage(lang) {
        if (!lang) return;
        try {
            localStorage.setItem(CACHE_LANG_KEY, lang);
        } catch { }

        const nodes = collectTextNodes(document.body);
        if (!nodes.length) return;

        const map = new Map();
        for (const node of nodes) {
            const original = node.nodeValue.trim();
            if (!map.has(original)) map.set(original, []);
            map.get(original).push(node);
        }

        const unique = Array.from(map.keys());
        const concurrency = 6;
        const results = {};
        for (let i = 0; i < unique.length; i += concurrency) {
            const batch = unique.slice(i, i + concurrency);
            await Promise.all(batch.map(async (text) => {
                try {
                    const t = await translateText(text, lang);
                    if (t) results[text] = t;
                } catch (e) {
                    console.warn('translate error', e);
                }
            }));
        }

        for (const [orig, nodeList] of map.entries()) {
            const translated = results[orig];
            if (!translated) continue;
            for (const node of nodeList) {
                const prefix = node.nodeValue.match(/^\s*/)?.[0] ?? '';
                const suffix = node.nodeValue.match(/\s*$/)?.[0] ?? '';
                node.nodeValue = prefix + translated + suffix;
            }
        }
    }

    async function translateAndObserve(lang) {
        await translatePage(lang);
        if (window.__myTranslatorObserver) return;
        const observer = new MutationObserver(async () => {
            if (window.__myTranslatorDebounce) clearTimeout(window.__myTranslatorDebounce);
            window.__myTranslatorDebounce = setTimeout(async () => {
                try {
                    await translatePage(localStorage.getItem(CACHE_LANG_KEY) || lang);
                } catch { }
            }, 250);
        });
        observer.observe(document.body, { childList: true, subtree: true });
        window.__myTranslatorObserver = observer;
    }

    function getSavedLanguage() {
        try {
            return localStorage.getItem(CACHE_LANG_KEY);
        } catch {
            return null;
        }
    }

    return {
        translatePage: translateAndObserve,
        translateText,
        getSavedLanguage
    };
})();

// --- Module-compatible exports ---
// These let you `import "./js/translate.js"` in Blazor and call exported functions.
export async function translatePage(lang) {
    if (window.myTranslator && typeof window.myTranslator.translatePage === 'function') {
        return window.myTranslator.translatePage(lang);
    }
    // fallback: try to call translatePage after small delay
    throw new Error('myTranslator not initialized');
}
export function getSavedLanguage() {
    if (window.myTranslator && typeof window.myTranslator.getSavedLanguage === 'function') {
        return window.myTranslator.getSavedLanguage();
    }
    return null;
}