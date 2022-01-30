using System;
using astator.Core;
using astator.Core.Accessibility;
using astator.Core.Script;

namespace Examples;
public class UiFinderTest
{
    [ScriptEntryMethod(FileName = "4.点击关于按钮.cs")]
    public static void Main(ScriptRuntime runtime)
    {
        if (!Globals.Permission.CheckAccessibilityService())
        {
            Globals.Toast("请先开启无障碍服务!");
            Console.WriteLine("请先开启无障碍服务!");
            return;
        }

        //在设置界面运行脚本
        var nodeInfo = UIFinder.FindOne(new SearcherArgs
        {
            Text = "关于"
        });

        if (nodeInfo is not null)
        {
            Globals.Toast("找到控件");

            //由于文本控件的clickable是false, 所以我们点击它的父控件
            Globals.Toast(nodeInfo.Parent.Click().ToString());

            //也可以点击他的坐标
            // var bounds = nodeInfo.GetBounds();
            // var centerX = (bounds.Right - bounds.Left) / 2 + bounds.Left;
            // var centerY = (bounds.Bottom - bounds.Top) / 2 + bounds.Top;
            // Automator.Click(centerX, centerY);
        }
    }
}
