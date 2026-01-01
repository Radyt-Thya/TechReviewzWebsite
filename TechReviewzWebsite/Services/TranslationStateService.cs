using Microsoft.JSInterop;

namespace TechReviewzWebsite.Services;

public class TranslationStateService
{
    private string? _currentLanguage;
    
    public event Action? OnLanguageChanged;

    public string? CurrentLanguage
    {
        get => _currentLanguage;
        set
        {
            if (_currentLanguage != value)
            {
                _currentLanguage = value;
                
                OnLanguageChanged?.Invoke();
            }
        }
    }

    public void ResetLanguage()
    {
        CurrentLanguage = null;
        OnLanguageChanged?.Invoke();
    }
}