using MiraAPI.GameOptions;
using MiraAPI.GameOptions.Attributes;

namespace AmongChamelleons.Options;

public class AmongChamelleonsOptions : AbstractOptionGroup
{
    public override string GroupName => "AmongChamelleons";

    [ModdedToggleOption("Test Toggle")]
    public bool TestToggle { get; set; } = false;
}
