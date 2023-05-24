using AmongUs.{all};
using BepInEx.{all};
using Inputter;
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
[BepInProcess("Among Us.exe"]

public class Main : BasePlugin
{
  // ============== Main 関係 ==============
  public static readonly string PluginName = "ExecuteAPI";
  public static readonly string PluginVersion = "1.0.0";
  public static readonly bool isRelease = true;
  public static readonly bool canPublic = true;
  // ============== Custom関係 ==============
  public static void CustomRoles;
  public static void CustomRPC;
  public static void CustomConfig;
  // ============== Utilities関係 ==============
  public static void Utilities.Effect;
  public static void Utilities.Action;
  //
}
