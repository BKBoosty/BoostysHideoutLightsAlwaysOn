using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BoostysHideoutLightsAlwaysOn.Client.Patches;

namespace BoostysHideoutLightsAlwaysOn.Client;

[BepInPlugin("com.boosty.hideoutlightsalwayson", "Boosty-HideoutLightsAlwaysOn", "1.0.1")]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log = null!;
    internal const int IlluminationAreaType = 15;

    private static ConfigEntry<bool>? _enableLightsAlwaysOn;
    private static ConfigEntry<int>? _minimumIlluminationLevel;

    internal static bool EnableLightsAlwaysOn => _enableLightsAlwaysOn?.Value ?? true;
    internal static int MinimumIlluminationLevel => _minimumIlluminationLevel?.Value ?? 0;

    private void Awake()
    {
        Log = Logger;

        _enableLightsAlwaysOn = Config.Bind(
            "General",
            "EnableLightsAlwaysOn",
            true,
            new ConfigDescription(
                "Enable/disable this client-side lights-always-on override. False keeps base game light power behavior."));

        _minimumIlluminationLevel = Config.Bind(
            "General",
            "MinimumIlluminationLevel",
            0,
            new ConfigDescription(
                "Only force lights ON when hideout Illumination level is at or above this value. 0 = no level gate.",
                new AcceptableValueRange<int>(0, 3)));

        new ForceHideoutEnergyPatch().Enable();
        new ForceHideoutShowPatch().Enable();

        _enableLightsAlwaysOn.SettingChanged += (_, _) => ForceHideoutEnergyPatch.ForceRefreshAmbianceFromCurrentState("config_EnableLightsAlwaysOn");
        _minimumIlluminationLevel.SettingChanged += (_, _) => ForceHideoutEnergyPatch.ForceRefreshAmbianceFromCurrentState("config_MinimumIlluminationLevel");

        Log.LogInfo($"Client patch enabled (light gating override). EnableLightsAlwaysOn={EnableLightsAlwaysOn}, MinimumIlluminationLevel={MinimumIlluminationLevel}");
    }
}
