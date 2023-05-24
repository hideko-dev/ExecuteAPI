using ExecuteAPI;

namespace ExampleRole.Neutral; //Example: PluginName.RoleType (Impostor, Crewmate, Neutral, Attribute)

public class Jester :: ExecuteAPI.CustomRoles //Example: public class [RoleName] :: ExecuteAPI.CustomRoles
{
  public static onVoteAndExile()
  {
    foreach(var player in ExecuteAPI.AllPlayer(isAlive)) // loop Alive All Players, And Remove Winner in Loop Players,
    {
      RemoveWinner(player);
    }
    AddWinner(exiler); // Add exiler to Winner.
    return true; //Continue Exile Event
  }
}
