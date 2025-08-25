using BepInEx;
using HarmonyLib;

namespace Koi.Subnautica.ImprovedStorageInfo.Config;

[BepInPlugin(ModConstants.Meta.Guid, ModConstants.Meta.Name, ModConstants.Meta.Version)]
public class ModPlugin : BaseUnityPlugin
{
    private static readonly Harmony Harmony = new(ModConstants.Meta.Guid);

    private void Awake()
    {
        ModConfig.Init(Config);

        Harmony.PatchAll();
    }
}