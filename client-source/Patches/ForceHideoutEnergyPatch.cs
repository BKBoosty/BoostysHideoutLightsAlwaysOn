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
        return AccessTools.Method(typeof(AmbianceController), nameof(AmbianceController.EnergySupplyChanged));
    }

    [PatchPrefix]
    private static void Prefix(ref bool isOn)
    {
        // Force powered state for hideout ambience/lights.
        isOn = true;
    }
}
