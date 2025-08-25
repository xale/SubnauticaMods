using HarmonyLib;
using Koi.Subnautica.ModTranslationHelper.Config;

namespace Koi.Subnautica.ModTranslationHelper.Patches
{
    [HarmonyPatch(typeof(uGUI_OptionsPanel))]
    public static class ModTranslationHelperUGuiOptionsPanelPatches
    {
        [HarmonyPatch(nameof(uGUI_OptionsPanel.OnSave))]
        [HarmonyPostfix]
        internal static void OnSave()
        {
            foreach (var translationsHandlers in TranslationHelper.TranslationsHandlers)
            {
                translationsHandlers.SetLanguage(Language.main.GetCurrentLanguage());
            }
        }
    }
}