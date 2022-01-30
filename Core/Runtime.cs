using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;    
using astator.Core;
using astator.Core.UI;
using astator.Core.UI.Floaty;
using astator.Core.Threading;
using static astator.Core.Globals.Permission;

namespace Examples;

public static class Runtime
{
    public static ScriptRuntime Instance { get; set; }

    public static string ScriptId { get => Instance.ScriptId; }

    public static UiManager Ui { get => Instance.Ui; }

    public static FloatyManager Floatys { get => Instance.Floatys; }

    public static ScriptThreadManager Threads { get => Instance.Threads; }

    public static ScriptTaskManager Tasks { get => Instance.Tasks; }

    public static bool IsUiMode { get => Instance.IsUiMode; }

    public static ScriptState State { get => Instance.State; }

    public static string Directory { get => Instance.Directory; }
}
