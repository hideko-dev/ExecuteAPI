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
  public static onKilled(string(killer), string(target))
  {
    if(string(killer) && string(target) == !null)
    {
      Inputter.onEvent([Inputter.toInput(AmongUs.PlayerControls.onMurderPlayer)])
      {
        consoler.addLog(Main.PluginName + "[Event] onKilled" + string(killer) + ">>" + string(target));
      }
    }
  }
}

public class Utilities :: Main.Utilities(Effect)
{
  public static killPlayer(string(killer), string(target), bool(silent))
}
