# ExecuteRoles
- Support Minecraft Mod Developments.

#
### Event Actions
**Template**  | `public static onKilled()` / `public static onFixSabotage()`
| Parameter | Listener                       |
| :-------- | :-------------------------------- |
| `onKilled` | Player Killed |
| `onVent` | Player In/Out Vent |
| `onShapeshift` | Player Shapeshift |
| `onSabotage` | Player Start Any Sabotage |
| `onFixSabotage` | Player Fix Any Sabotage |
| `onTaskEnd` | Player End Tasks. |
| `onAllTaskEnd` | Player End All Tasks. |
| `onMeeting` | Player Start Meeting. |
| `onReport` | Player Report DeadBody. |
| `onRift` | Player used Rift. |

#
### Call Data (Live Data)
**Template**  | `eventer.getData.isDead` / `target.getData.MainRole.Type`
| Parameter | Listener                       | Output |
| :-------- | :-------------------------------- | :----------------- |
| `getData.VectorPotision` | Player's Vector3 Location | num-x, num-y |
| `getData.isDead` | Player is Dead or Alive | true / false |
| `getData.LiveName` | Player's Realtime Name | string |
| `getData.RealName` | Player's Real Game Name | string |
| `getData.FriendCode` | Player's Friend Code | string#num |
| `getData.MainRole` | Player's Main Role ID | string |
| `getData.MainRole.Type` | Player's Main Role Type | string |
| `getData.SubRole` | Player's Sub Role ID | string |
| `getData.Skin.FakeColor` | Player's Replaced Skin Color | num |
| `getData.Skin.FakeNamePlate` | Player's Replaced NamePlate | num |
| `getData.Skin.FakePet` | Player's Replaced Pet | num |
| `getData.Skin.FakeHead` | Player's Replaced Head | num |
| `getData.Skin.RealColor` | Player's Real Skin Color | num |
| `getData.Skin.RealNamePlate` | Player's Real NamePlate | num |
| `getData.Skin.RealPet` | Player's Real Pet | num |
| `getData.Skin.RealHead` | Player's Real Head | num |

```
基本時に、イベントを引き起こした「eventer」
onMurderやonShapeshiftなどで、ターゲットがいる場合は、「eventer」と「target」
このようにイベントごとに対象が指定されています。
```
