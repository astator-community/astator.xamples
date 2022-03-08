using System;
using astator.Core.Accessibility;
using astator.Core.Script;
using Examples.Core;

namespace Examples;
public class UiFinderTest
{
    [ScriptEntryMethod(FileName = "04.点击关于按钮.cs")]
    public static void Main(ScriptRuntime runtime)
    { 
        Runtime.Instance = runtime;
        if (!Runtime.PermissionHelper.CheckAccessibility())
        {
            Globals.Toast("请先开启无障碍服务!");
            Console.WriteLine("请先开启无障碍服务!");
            return;
        }

        //在设置界面运行脚本
        var node = Automator.GetCurrentWindowInfo();
        var tv = node.FindOne(new SearcherArgs
        {
            Text = "关于"
        });

        if (tv is not null)
        {
            Globals.Toast("找到控件");
            //由于文本控件的clickable是false, 所以我们使用坐标点击
            var bounds = tv.GetBounds();
            Automator.Click(bounds.GetCenterX(), bounds.GetCenterY());
        }
    }
}
