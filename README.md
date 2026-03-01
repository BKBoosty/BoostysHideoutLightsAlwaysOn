# Boosty's Hideout Lights Always On

Version: `1.0.0`  
SPT target: `~4.0.0`

## What This Mod Does

- Lets hideout illumination work without generator fuel.
- Keeps normal hideout progression (you still need Illumination built/upgraded).
- Keeps your normal light mode choice in hideout.

## Install

1. Close SPT server, launcher, and game.
2. Extract `BoostysHideoutLightsAlwaysOn-1.0.0.zip` into your SPT folder.
3. Confirm client file exists:
   `BepInEx/plugins/BoostysHideoutLightsAlwaysOn.Client.dll`
4. Confirm server file exists:
   `SPT/user/mods/boostys-hideout-lights-always-on/BoostysHideoutLightsAlwaysOn.dll`
5. If your setup is single-root (no nested `SPT` folder), use:
   `user/mods/boostys-hideout-lights-always-on/BoostysHideoutLightsAlwaysOn.dll`
6. Restart server and game.

## Fika Note

- The server mod must be installed on the host/server.
- The client DLL must be installed on each player client.

## Quick Check

- Server startup log should contain:
  `[BoostysHideoutLightsAlwaysOn] Illumination no longer requires generator fuel.`
- Client `BepInEx/LogOutput.log` should contain:
  `Client patch enabled (light gating override).`

## Uninstall

1. Remove `BepInEx/plugins/BoostysHideoutLightsAlwaysOn.Client.dll`
2. Remove `SPT/user/mods/boostys-hideout-lights-always-on` (or `user/mods/...` on single-root setups)
3. Restart server and game.

## Source Code

Public source (for both DLLs):  
`https://github.com/BKBoosty/BoostysHideoutLightsAlwaysOn`

## License

This mod is licensed under `CC BY-NC 4.0` (Creative Commons Attribution-NonCommercial 4.0 International).

Commercial use is not allowed without separate permission from the author.
