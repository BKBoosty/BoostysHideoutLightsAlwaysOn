# Boosty's Hideout Lights Always On

Version: `1.0.0`  
SPT target: `~4.0.0`

Server + client package for SPT 4.0.x.

## Purpose

- Keeps hideout lights usable without turning on the generator.
- Keeps normal illumination unlock/progression behavior.
- Keeps manual light mode selection behavior.

## Dependencies

- No third-party mod dependencies.
- Requires standard SPT 4.0.x runtime:
  - Server side: SPT server assemblies.
  - Client side: BepInEx + Harmony + `spt-reflection` (included with SPT installs).

## Standalone Use

- Works as a standalone mod package on any SPT 4.0.x install.
- Does not require Fika. If using Fika, each player still needs the client DLL.

## Required Pieces

- Server: `SPT/user/mods/boostys-hideout-lights-always-on/BoostysHideoutLightsAlwaysOn.dll`
- Client install target (every player): `BepInEx/plugins/BoostysHideoutLightsAlwaysOn.Client.dll`

## Source Code Links (Required for DLLs)

- `BoostysHideoutLightsAlwaysOn.dll` source:
  `https://github.com/BKBoosty/BoostysHideoutLightsAlwaysOn/tree/main/source`
- `BoostysHideoutLightsAlwaysOn.Client.dll` source:
  `https://github.com/BKBoosty/BoostysHideoutLightsAlwaysOn/tree/main/client-source`

Before distributing binaries, ensure the linked repository is publicly accessible.

## Install

1. Place the server mod folder in `SPT/user/mods/` on the server host.
2. Place `BoostysHideoutLightsAlwaysOn.Client.dll` in `BepInEx/plugins/` on each client.
3. Restart server and game.

## Verify

- Server log contains:
  `[BoostysHideoutLightsAlwaysOn] Illumination no longer requires generator fuel.`
- Client `BepInEx/LogOutput.log` contains:
  `Client patch enabled (light gating override).`

## Build

Server DLL:

```powershell
cd source
dotnet build -c Release -p:SptRoot=C:\Path\To\Your\SPT
```

Client DLL:

```powershell
cd client-source
dotnet build -c Release -p:SptRoot=C:\Path\To\Your\SPT
```
