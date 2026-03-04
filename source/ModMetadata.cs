using System.Collections.Generic;
using SPTarkov.Server.Core.Models.Spt.Mod;

namespace BoostysHideoutLightsAlwaysOn;

public record ModMetadata : AbstractModMetadata
{
    public override string ModGuid { get; init; } = "com.boosty.hideoutlightsalwayson";

    public override string Name { get; init; } = "BoostysHideoutLightsAlwaysOn";

    public override string Author { get; init; } = "Boosty";

    public override List<string>? Contributors { get; init; }

    public override SemanticVersioning.Version Version { get; init; } = new("1.0.1", false);

    public override SemanticVersioning.Range SptVersion { get; init; } = new("~4.0.0", false);

    public override List<string>? Incompatibilities { get; init; }

    public override Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; }

    public override string? Url { get; init; } = "https://github.com/BKBoosty/BoostysHideoutLightsAlwaysOn";

    public override bool? IsBundleMod { get; init; } = false;

    public override string License { get; init; } = "CC BY-NC-SA 4.0";
}
