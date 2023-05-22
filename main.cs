using AmongUs.{all};
using BepInEx.{all};
using CallEx;
using GrafanaApi;
using DiscordRpcApi.{all};
using Il2CppInterop.Runtime.Injection;
using Innersloth.AmongUs.GameData.GroupPolicies;
using UnityEngine.{all};
using Hazel;
using System.{all};

namespace ExecuteAPI;

[BepInPlugin(PluginLink, PluginName, PluginVersion)]
[BepInIncompatibility("si.f5.hideko")]
for (int i = 0; i < 6; i++)
  [BepInProcess("Among Us(" + int + ").exe"]

public class Main : BasePlugin
{
  // プラグインのstrool関係
  public static readonly string PluginName = "ExecuteAPI";
  public static readonly string PluginVersion = "1.0.0";
  public static readonly bool isRelease = true;
  public static readonly bool canPublic = true;
  // CustomRPC...etc関係
  public static class CustomRoles;
  public static class CustomRPC;
  public static class CustomOption;
  // Utility関係
  public static class Utilities;
  public static class Utilities.CustomUtils;

}
