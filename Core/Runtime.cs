using Android.App;
using astator.Core.Script;
using astator.Core.Threading;
using astator.Core.UI;
using astator.Core.UI.Floaty;
using System;

namespace Examples.Core;
public static class Runtime
{

    /// <summary>
    /// 实例
    /// </summary>
    public static ScriptRuntime Instance { get; set; }

    /// <summary>
    /// 脚本自身的activity, 非ui模式时为null
    /// </summary>
    public static Activity Activity => Instance.Activity;

    /// <summary>
    /// 脚本id
    /// </summary>
    public static string ScriptId => Instance.ScriptId;

    /// <summary>
    /// ui管理类
    /// </summary>
    public static UiManager Ui => Instance.Ui;

    /// <summary>
    /// 悬浮窗相关
    /// </summary>
    public static FloatyHelper FloatyHelper => Instance.FloatyHelper;

    /// <summary>
    /// 线程管理类
    /// </summary>
    public static ThreadManager Threads => Instance.Threads;

    /// <summary>
    /// Task管理类
    /// </summary>
    public static TaskManager Tasks => Instance.Tasks;

    public static PermissionHelper PermissionHelper => Instance.PermissionHelper;

    /// <summary>
    /// 是否为ui模式
    /// </summary>
    public static bool IsUiMode => Instance.IsUiMode;

    /// <summary>
    /// 脚本工作路径
    /// </summary>
    public static string WorkDir => Instance.WorkDir;

    /// <summary>
    /// 在脚本停止时退出应用, 只在打包apk有效
    /// </summary>
    public static bool IsExitAppOnStoped => Instance.IsExitAppOnStoped;

    /// <summary>
    /// 添加一个脚本停止时的回调
    /// </summary>
    public static void AddExitCallback(Action callback) => Instance.AddExitCallback(callback);

    /// <summary>
    /// 添加一个logger的回调
    /// </summary>
    /// <returns>回调的key</returns>
    public static string AddLoggerCallback(Action<LogLevel, DateTime, string> callback) => Instance.AddLoggerCallback(callback);

    /// <summary>
    /// 移除logger的回调
    /// </summary>
    /// <param name="key">回调的key, 当key为空时移除当前runtime添加的所有logger回调</param>
    public static void RemoveLoggerCallback(string key = null) => Instance.RemoveLoggerCallback(key);

    /// <summary>
    /// 停止脚本
    /// </summary>
    public static void SetStop() => Instance.SetStop();
}
