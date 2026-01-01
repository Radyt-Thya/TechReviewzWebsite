using Microsoft.AspNetCore.Components;
using TechReviewzWebsite.Services;

namespace TechReviewzWebsite.Components;

public class TranslatablePage : ComponentBase, IDisposable
{
    [Inject] protected TranslationService TS { get; set; } = default!;
    [Inject] protected TranslationStateService State { get; set; } = default!;

    private Dictionary<string, string> _cache = new();
    private List<string> _pendingTexts = new();
    private bool _isInitialLoad = true;

    protected override void OnInitialized()
    {
        State.OnLanguageChanged += HandleLanguageChanged;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && _isInitialLoad && _pendingTexts.Any() && !string.IsNullOrEmpty(State.CurrentLanguage))
        {
            _isInitialLoad = false;
            await TranslatePendingBatchAsync();
        }
    }

    private async void HandleLanguageChanged()
    {
        _cache.Clear();
        _pendingTexts.Clear();
        _isInitialLoad = true;
        await InvokeAsync(StateHasChanged);
    }

    protected string T(string text)
    {
        // No translation needed
        if (string.IsNullOrEmpty(State.CurrentLanguage)) 
            return text;

        // Return cached translation
        if (_cache.TryGetValue(text, out var cached))
            return cached;

        // Add to pending list for batch translation
        if (!_pendingTexts.Contains(text))
        {
            _pendingTexts.Add(text);
        }

        // Return original text (will be updated after translation)
        return text;
    }

    private async Task TranslatePendingBatchAsync()
    {
        var textsToTranslate = _pendingTexts.ToList();
        _pendingTexts.Clear();

        Console.WriteLine($"[TranslatablePage] Translating {textsToTranslate.Count} texts to {State.CurrentLanguage}");

        foreach (var text in textsToTranslate)
        {
            try
            {
                var result = await TS.TranslateTextAsync(text, State.CurrentLanguage);
                
                if (!string.IsNullOrEmpty(result))
                {
                    _cache[text] = result;
                    Console.WriteLine($"[T] '{text}' → '{result}'");
                }
                else
                {
                    Console.WriteLine($"[T] '{text}' → (null/failed)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[T] ERROR translating '{text}': {ex.Message}");
            }
        }

        await InvokeAsync(StateHasChanged); // Re-render with all translations
        Console.WriteLine($"[TranslatablePage] Batch translation complete, re-rendering");
    }

    public void Dispose()
    {
        State.OnLanguageChanged -= HandleLanguageChanged;
    }
}