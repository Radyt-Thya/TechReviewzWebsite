using Microsoft.AspNetCore.Components;

namespace TechReviewzWebsite.Services;

public static class TranslationExtensions
{
    public static MarkupString Translate(this string text, TranslationStateService stateService, TranslationService translationService)
    {
        if (string.IsNullOrWhiteSpace(stateService?.CurrentLanguage))
            return new MarkupString(text);

        // This will be async, but we'll use a sync wrapper for simplicity
        var translated = translationService.TranslateTextAsync(text, stateService.CurrentLanguage).GetAwaiter().GetResult();
        return new MarkupString(translated ?? text);
    }
}