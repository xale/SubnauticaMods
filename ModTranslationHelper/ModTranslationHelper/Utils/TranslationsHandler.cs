namespace Koi.Subnautica.ModTranslationHelper.Utils;

public class TranslationsHandler
{
    private readonly Translations _translations;

    internal TranslationsHandler(string languagesPath)
    {
        _translations = new Translations(languagesPath);
    }

    public string GetTranslation(string key, string defaultValue)
    {
        return _translations.GetTranslation(key, defaultValue);
    }

    internal void SetLanguage(string language)
    {
        _translations.SetLanguage(language);
    }
}