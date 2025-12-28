// Lightweight page translator using MyMemory with localStorage caching.
// Usage: myTranslator.translatePage('es')
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

    // Walk DOM and collect text nodes (excluding script/style, inputs, textareas)
    function collectTextNodes(root = document.body) {
        const walker = document.createTreeWalker(root, NodeFilter.SHOW_TEXT, {
            acceptNode(node) {
                if (!node.nodeValue) return NodeFilter.FILTER_REJECT;
                const parent = node.parentElement;
                if (!parent) return NodeFilter.FILTER_REJECT;
                const tag = parent.tagName.toLowerCase();
                // ignore script, style, textarea, input, code, pre, svg, button value etc.
                const ignored = ['script', 'style', 'textarea', 'input', 'pre', 'code', 'svg', 'noscript'];
                if (ignored.includes(tag)) return NodeFilter.FILTER_REJECT;
                const text = node.nodeValue.trim();
                if (!text) return NodeFilter.FILTER_REJECT;
                // ignore numbers-only or single chars
                if (text.length < 2) return NodeFilter.FILTER_REJECT;
                return NodeFilter.FILTER_ACCEPT;
            }
        });

        const nodes = [];
        let n;
        while (n = walker.nextNode()) nodes.push(n);
        return nodes;
    }

    // Main entry: translate unique text nodes and replace in-place
    async function translatePage(lang) {
        if (!lang) return;
        try {
            // store chosen language
            localStorage.setItem(CACHE_LANG_KEY, lang);
        } catch { }

        const nodes = collectTextNodes(document.body);
        if (!nodes.length) return;

        // Build map of original text -> [nodes]
        const map = new Map();
        for (const node of nodes) {
            const original = node.nodeValue.trim();
            if (!map.has(original)) map.set(original, []);
            map.get(original).push(node);
        }

        const unique = Array.from(map.keys());
        // translate sequentially with small concurrency to reduce rate pressure
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

        // Replace node text if translation available
        for (const [orig, nodeList] of map.entries()) {
            const translated = results[orig];
            if (!translated) continue;
            for (const node of nodeList) {
                // preserve surrounding whitespace
                const prefix = node.nodeValue.match(/^\s*/)?.[0] ?? '';
                const suffix = node.nodeValue.match(/\s*$/)?.[0] ?? '';
                node.nodeValue = prefix + translated + suffix;
            }
        }
    }

    async function translateAndObserve(lang) {
        await translatePage(lang);
        // Optional: observe DOM mutations to translate newly added nodes
        if (window.__myTranslatorObserver) return;
        const observer = new MutationObserver(async (list) => {
            // small debounce
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

// ensure global aliases exist for any legacy calls
window.translatePage = (lang) => {
  if (window.myTranslator && typeof window.myTranslator.translatePage === 'function') {
    return window.myTranslator.translatePage(lang);
  }
  return Promise.reject(new Error('myTranslator not initialized'));
};
window.getSavedLanguage = () => {
  if (window.myTranslator && typeof window.myTranslator.getSavedLanguage === 'function') {
    return window.myTranslator.getSavedLanguage();
  }
  return null;
};

// --- ES module exports (required for `import('/js/translate.js')`) ---
export function translatePage(lang) {
    // return the promise from the global implementation
    if (window.myTranslator && typeof window.myTranslator.translatePage === 'function') {
        return window.myTranslator.translatePage(lang);
    }
    return Promise.reject(new Error('myTranslator not initialized'));
}

export function getSavedLanguage() {
    if (window.myTranslator && typeof window.myTranslator.getSavedLanguage === 'function') {
        return window.myTranslator.getSavedLanguage();
    }
    return null;
}