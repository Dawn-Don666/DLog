/**
======================================
  *    FileName: DLogManager.cs
  *    CreatorName: Dawn
  *    CreateTime: 2023 三月 05 星期日
  *    功能描述: 日志管理器
======================================
*/

using Dawn.Log;

public class DLogManager
{
    private static DLogManager instance;
    public static DLogManager Instance => instance ??= new DLogManager();

    public void Init()
    {
        DLogConfig config = new DLogConfig
        {
            EnableLog = true,                      //是否开启日志
            EnableLogFlag = true,                  //是否开启日志标识符
            EnableFontColor = true,                //是否开启字体颜色
            EnableMilli = false,                   //是否开启毫秒显示
            EnableThreadID = false,                //是否开启线程ID
            EnableTrace = true,                    //是否开启堆栈信息
            EnableSave = true,                     //是否保存日志
            EnableCover = true,                    //是否覆盖日志
            //SaveLogName = "",                    //保存日志名字 默认为: "DLog.txt"
            //SaveLogPath = ""                     //保存日志路径 默认为: Application.persistentDataPath + "/UnityLogs/"
        };
        DLog.Init(config);
        DLog.Log("日志管理器初始化成功", DLogColor.NB);
        DLog.Log("Log manager initialization succeeded", DLogColor.NB);
        DLog.Error("日志管理器初始化失败");
        DLog.Warning("日志管理器初始化可能失败");
        DLog.Log("日志管理器初始化成功");
        DLog.Log("日志管理器初始化成功", DLogColor.RED);
        DLog.Log("日志管理器初始化成功", DLogColor.ORANGE);
        DLog.Log("日志管理器初始化成功", DLogColor.YELLOW);
        DLog.Log("日志管理器初始化成功", DLogColor.GREEN);
        DLog.Log("日志管理器初始化成功", DLogColor.CYAN);
        DLog.Log("日志管理器初始化成功", DLogColor.BLUE);
        DLog.Log("日志管理器初始化成功", DLogColor.VIOLET);
    }
}