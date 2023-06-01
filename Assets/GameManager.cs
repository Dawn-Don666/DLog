/**
======================================
  *    FileName: GameManager.cs
  *    CreatorName: Dawn
  *    CreateTime: 2023 三月 05 星期日
  *    功能描述: 游戏启动入口
======================================
*/

using Dawn.Log;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private void Awake()
    {
        DLogManager.Instance.Init();
        InIt();
    }

    private void InIt()
    {
        DLog.Log("GameManager 初始化成功", DLogColor.NB);
    }
}