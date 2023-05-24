using ExecuteAPI;

namespace ExampleRole.Crewmate; //Example: PluginName.RoleType (Impostor, Crewmate, Neutral, Attribute)

public class Bait :: ExecuteAPI.CustomRoles //Example: public class [RoleName] :: ExecuteAPI.CustomRoles
{
  public static onKilled() // on player killed evnent
  {
    openReport(killer, target); //Open Report Dead Body Meeting.
    return true; //Continue Kill Event
  }
}
