﻿using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using LiarsBarEnhance.Features;

namespace LiarsBarEnhance;

[BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal new static ManualLogSource Logger;
    internal static Harmony _harmony = new(PluginInfo.PLUGIN_GUID);

    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        
        Harmony.CreateAndPatchAll(typeof(RemoveHeadRotationlimitPatch), nameof(RemoveHeadRotationlimitPatch));
        Harmony.CreateAndPatchAll(typeof(CrazyShakeHeadPatch), nameof(CrazyShakeHeadPatch));
        Harmony.CreateAndPatchAll(typeof(ChatProPatch), nameof(ChatProPatch));
        Harmony.CreateAndPatchAll(typeof(CharMoveablePatch), nameof(CharMoveablePatch));
        Harmony.CreateAndPatchAll(typeof(BigMouthPatch), nameof(BigMouthPatch));
        Harmony.CreateAndPatchAll(typeof(ChineseNameFixPatch), nameof(ChineseNameFixPatch));
        Harmony.CreateAndPatchAll(typeof(RemoveNameLengthLimitPatch), nameof(RemoveNameLengthLimitPatch));
        Harmony.CreateAndPatchAll(typeof(FzHintPatch), nameof(FzHintPatch));
        Harmony.CreateAndPatchAll(typeof(SelectableLevelPatch), nameof(SelectableLevelPatch));
        
        Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
    }
}