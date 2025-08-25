using System.IO;
using Koi.Subnautica.ModTranslationHelper.Config;
using Koi.Subnautica.ModTranslationHelper.Utils;

namespace Koi.Subnautica.ImprovedStorageInfo.Config;

public static class ModTranslations
{
    public static readonly TranslationsHandler TranslationsHandler =
        TranslationHelper.AddTranslations(
            $"{Path.GetDirectoryName(typeof(ModPlugin).Assembly.Location)}/{ModConstants.Translations.RootFolder}"
        );
}