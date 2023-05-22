# ExecuteRoles
AmongUsのModを作成するのをサポートするAPIです。

### Event Actions

| イベント | イベントの内容 |
| -------- | ---- |
| `onMurder` | プレイヤーが殺されたら |
| `onVent` | プレイヤーがベントに入ったら/出たら |
| `onShapeshift` | プレイヤーがシェイプシフトしたら |
| `onMove` | プレイヤーが動いたら |
| `onMoveStop` | プレイヤーが止まったら |
| `onTaskEnd` | プレイヤーがタスクを終了したら |
| `onMeeting` | プレイヤーが会議を開始したら |
| `onReport` | プレイヤーが死体を通報したら |
| `onSabotage` | プレイヤーがサボタージュを開始したら |
| `onFixSabotage` | プレイヤーがサボタージュを修理したら |

### String Actions

| 呼び出し | 出力する内容 |
| -------- | ---- |
| `getPotision` | プレイヤーのVector3値の位置 |
| `getData.isDead` | プレイヤーが死んでるか |
| `getData.isDead` | プレイヤーが死んでるか |

```
基本時に、イベントを引き起こした「eventer」
onMurderやonShapeshiftなどで、ターゲットがいる場合は、「eventer」と「target」
このようにイベントごとに対象が指定されています。
```
