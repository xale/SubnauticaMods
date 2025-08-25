using System.Collections.Generic;
using Koi.Subnautica.ModTranslationHelper.Utils;

namespace Koi.Subnautica.ModTranslationHelper.Config;

public static class TranslationHelper
{
    internal static readonly List<TranslationsHandler> TranslationsHandlers = new();

    public static TranslationsHandler AddTranslations(string languagesPath)
    {
        var translationHandler = new TranslationsHandler(languagesPath);

        translationHandler.SetLanguage(Language.main.GetCurrentLanguage());

        TranslationsHandlers.Add(translationHandler);

        return translationHandler;
    }
}