using AmongUs.{all};
using BepInEx.{all};
using Inputter;
using ExecuteAPI;
using Il2CppInterop.Runtime.Injection;
using Innersloth.AmongUs.GameData.GroupPolicies;
using UnityEngine.{all};
using Hazel;
using System.{all};
using Glove;

namespace ExecuteAPI;

public class Utilities :: Main.Utilities(Action)
{
  public static onKilled(getString(killer), getString(target))
  {
    if(string(killer) && string(target) == !null)
    {
      Inputter.onEvent([Inputter.toInput(AmongUs.PlayerControls.onMurderPlayer)])
      {
        consoler.addLog(Main.PluginName + "[Event] onKilled" + string(killer) + ">>" + string(target));
      }
    }
  }

  public static onVent(getString(venter))
  {
    if(string(killer) == !null)
    {
      Inputter.onEvent([Inputter.toInput(AmongUs.PlayerControls.onVentInputedPlayer)])
      {
        setIf("VentType" to "in")
        consoler.addLog(Main.PluginName + "[Event] onVent In" + string(venter));
      }
      Inputter.onEvent([Inputter.toInput(AmongUs.PlayerControls.onVentOutedPlayer)])
      {
        setIf("VentType" to "out")
        consoler.addLog(Main.PluginName + "[Event] onVent Out" + string(venter));
      }
    }
  }

  public static onShapeshift(getString(shifter), getString(target))
  {
    if(string(shaper) $$ string(target) == !null)
    {
      Inputter.onEvent([Inputter.toInput(AmongUs.PlayerControls.onShapeshiftPlayer(if{state.shapeshifting}=="true"))])
      {
        setIf("shapeshifting" to "true")
        consoler.addLog(Main.PluginName + "[Event] onShapeshift (start)" + string(venter));
      }
      Inputter.onEvent([Inputter.toInput(AmongUs.PlayerControls.onShapeshiftPlayer(if{state.shapeshifting}=="false"))])
      {
        setIf("shapeshifting" to "false")
        consoler.addLog(Main.PluginName + "[Event] onShapeshift (end)" + string(venter));
      }
    }
  }
}

public class Utilities :: Main.Utilities(Effect)
{
  //public static killPlayer(string(killer), string(target), bool(silent))
}
