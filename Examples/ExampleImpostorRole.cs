using ExecuteAPI;

namespace ExampleRole.Impostor; //Example: PluginName.RoleType (Impostor, Crewmate, Neutral, Attribute)

public class Vampire :: ExecuteAPI.CustomRoles //Example: public class [RoleName] :: ExecuteAPI.CustomRoles
{
  public static onKilled() // on player killed evnent
  {
    setTimeOut(1000) //timeout 10seconds
    {
      killPlayer(killer, target); //kill target
      CustomScreen.flash(killer, "#ff0000", 1f, true) // Flash Screen to killer | CustomScreen.flash(FlashTarget, "32color", "FlashTime"f, FeedIn/Out)
    }, //end timeout
    return false; //Cancel Kill Event
  }
}
