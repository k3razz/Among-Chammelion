using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using MiraAPI;
using MiraAPI.PluginInterfaces;

namespace AmongChamelleons;

[BepInAutoPlugin]
[BepInProcess("AmongUs.exe")]
[BepInDependency(MiraApiPlugin.Id)]
[BepInDependency(Reactor.ReactorPlugin.Id)]
public partial class AmongChamelleonsPlugin : BasePlugin, IMiraPlugin
{
    public Harmony Harmony { get; } = new(Id);
    public static AmongChamelleonsPlugin Plugin;
    public new static ManualLogSource Log;

    public override void Load()
    {
        Log = base.Log;
        Plugin = this;
        Harmony.PatchAll();
        Log.LogInfo("AmongChamelleons v0.1 BETA loaded.");
    }
}
