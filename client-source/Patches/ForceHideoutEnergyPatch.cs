using System;
using System.Reflection;
using EFT.Hideout;
using HarmonyLib;
using SPT.Reflection.Patching;

namespace BoostysHideoutLightsAlwaysOn.Client.Patches;

internal class ForceHideoutEnergyPatch : ModulePatch
{
    protected override MethodBase GetTargetMethod()
    {
        return AccessTools.Method(typeof(HideoutController), "method_6");
    }

    [PatchPostfix]
    private static void Postfix(HideoutController __instance)
    {
        var cameraField = AccessTools.Field(typeof(HideoutController), "_hideoutCameraController");
        var levelField = AccessTools.Field(typeof(HideoutController), "elightingLevel_0");

        if (cameraField?.GetValue(__instance) is not HideoutCameraController camera)
        {
            return;
        }

        if (levelField?.GetValue(__instance) is not ELightingLevel level)
        {
            return;
        }

        // Keep light visuals active regardless of generator state, while preserving level choice rules.
        camera.SurroundingIllumination = level != ELightingLevel.Candles && level != ELightingLevel.HalloweenLights;
    }
}
