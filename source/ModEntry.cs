using System;
using System.Threading.Tasks;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Enums.Hideout;
using SPTarkov.Server.Core.Models.Utils;
using SPTarkov.Server.Core.Services;

namespace BoostysHideoutLightsAlwaysOn;

[Injectable(InjectionType.Singleton)]
public class ModEntry(ISptLogger<ModEntry> logger, DatabaseService databaseService) : IOnLoad
{
    public Task OnLoad()
    {
        var hideout = databaseService.GetHideout();
        var illuminationArea = hideout?.Areas?.Find(area => area.Type == HideoutAreas.Illumination);

        if (illuminationArea == null)
        {
            logger.Warning("[BoostysHideoutLightsAlwaysOn] Illumination area not found in hideout database.");
            return Task.CompletedTask;
        }

        illuminationArea.NeedsFuel = false;
        logger.Success("[BoostysHideoutLightsAlwaysOn] Illumination no longer requires generator fuel.", (Exception?)null);
        return Task.CompletedTask;
    }
}
