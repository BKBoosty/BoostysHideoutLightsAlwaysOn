# Changelog

## 1.0.1
- Added F12 configs:
  - `EnableLightsAlwaysOn` (`true/false`, default `true`)
  - `MinimumIlluminationLevel` (`0-3`, default `0`)
- Added Illumination-level gating for the client-side lights-always-on override.
- Applied config behavior during hideout screen show and on runtime config changes.
- Fixed runtime behavior so the patch only forces lights `ON` when conditions are met and never forces them `OFF`.

## 1.0.0
- First public release.
- Includes server mod and client plugin.
- Server mod sets hideout Illumination (`type: 15`) `needsFuel = false`.
- Client plugin removes generator-off light gating while preserving selected light level behavior.
- License set to `CC BY-NC-SA 4.0` (non-commercial, share-alike).
