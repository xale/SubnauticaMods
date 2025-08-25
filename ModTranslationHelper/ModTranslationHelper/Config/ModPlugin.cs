using BepInEx;
using HarmonyLib;

namespace Koi.Subnautica.ModTranslationHelper.Config;

[BepInPlugin(ModConstants.Meta.Guid, ModConstants.Meta.Name, ModConstants.Meta.Version)]
internal class ModPlugin : BaseUnityPlugin
{
    private static readonly Harmony Harmony = new(ModConstants.Meta.Guid);

    private void Awake()
    {
        Harmony.PatchAll();
    }
}