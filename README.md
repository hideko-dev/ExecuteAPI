# ExecuteRoles
Support Minecraft Mod Developments.

### Event Actions

| Listener | Description |
| -------- | ---- |
| `onKilled` | Player Killed |
| `onVent` | Player In/Out Vent |
| `onShapeshift` | Player Shapeshift |
| `onTaskEnd` | Player End Tasks. |
| `onAllTaskEnd` | Player End All Tasks. |
| `onMeeting` | Player Start Meeting. |
| `onReport` | Player Report DeadBody. |
| `onSabotage` | Player Start Any Sabotage |
| `onFixSabotage` | Player Fix Any Sabotage |

### String Actions

| Listener | Output |
| -------- | ---- |
| `getPotision` | プレイヤーのVector3値の位置 |
| `getData.isDead` | プレイヤーが死んでるか |
| `getData.isDead` | プレイヤーが死んでるか |

```
基本時に、イベントを引き起こした「eventer」
onMurderやonShapeshiftなどで、ターゲットがいる場合は、「eventer」と「target」
このようにイベントごとに対象が指定されています。
```
