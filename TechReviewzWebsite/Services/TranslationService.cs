using System.Text.Json;
using System.Text.Json.Serialization;

namespace TechReviewzWebsite.Services;

public class TranslationService
{
    private readonly HttpClient _httpClient;
    private readonly Dictionary<string, Dictionary<string, string>> _cache = new();

    public TranslationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string?> TranslateTextAsync(string text, string targetLang, string sourceLang = "en")
    {
        if (string.IsNullOrWhiteSpace(text) || string.IsNullOrWhiteSpace(targetLang))
            return null;

        // Check memory cache first
        var cacheKey = $"{sourceLang}|{targetLang}";
        if (_cache.TryGetValue(cacheKey, out var langCache) && langCache.TryGetValue(text, out var cached))
            return cached;

        try
        {
            var encodedText = System.Net.WebUtility.UrlEncode(text);
            var url = $"https://api.mymemory.translated.net/get?q={encodedText}&langpair={sourceLang}|{targetLang}";
            
            Console.WriteLine($"Translating: {text} to {targetLang}");
            
            var response = await _httpClient.GetAsync(url);
            
            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"Translation API failed: {response.StatusCode}");
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"Translation API response: {json}");
            
            var result = JsonSerializer.Deserialize<MyMemoryResponse>(json, new JsonSerializerOptions 
            { 
                PropertyNameCaseInsensitive = true 
            });
            
            var translated = result?.ResponseData?.TranslatedText;

            if (!string.IsNullOrEmpty(translated))
            {
                // Cache the result
                if (!_cache.ContainsKey(cacheKey))
                    _cache[cacheKey] = new Dictionary<string, string>();
                _cache[cacheKey][text] = translated;
                
                Console.WriteLine($"Translation successful: {text} -> {translated}");
            }
            else
            {
                Console.WriteLine("Translation returned null or empty");
            }

            return translated;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Translation error: {ex.Message}");
            Console.WriteLine($"Stack trace: {ex.StackTrace}");
            return null;
        }
    }

    private class MyMemoryResponse
    {
        [JsonPropertyName("responseData")]
        public ResponseDataClass? ResponseData { get; set; }
        
        public class ResponseDataClass
        {
            [JsonPropertyName("translatedText")]
            public string? TranslatedText { get; set; }
        }
    }
}