using BepInEx;
using BepInEx.Logging;
using BoostysHideoutLightsAlwaysOn.Client.Patches;
using SPT.Reflection.Patching;

namespace BoostysHideoutLightsAlwaysOn.Client;

[BepInPlugin("com.boosty.hideoutlightsalwayson", "Boosty-HideoutLightsAlwaysOn", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log = null!;

    private void Awake()
    {
        Log = Logger;
        new ForceHideoutEnergyPatch().Enable();
        Log.LogInfo("Client patch enabled (light gating override).");
    }
}
