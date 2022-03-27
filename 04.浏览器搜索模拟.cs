using System;
using System.Threading;
using astator.Core.Accessibility;
using astator.Core.Script;
using Examples.Core;

namespace Examples;
public class UiFinderTest
{
    [ScriptEntryMethod(FileName = "04.浏览器搜索模拟.cs")]
    public static void Main(ScriptRuntime runtime)
    {
        Runtime.Instance = runtime;
        if (!Runtime.PermissionHelper.CheckAccessibility())
        {
            Globals.Toast("请先开启无障碍服务!");
            Console.WriteLine("请先开启无障碍服务!");
            return;
        }

        //在360浏览器首页运行
        while (true)
        {
            Thread.Sleep(1000);
            var root = Automator.GetCurrentWindowRoot();

            var node1 = root.FindOne(new SearcherArgs
            {
                Id = "aw3",
                ClassName = "android.widget.TextView"
            });
            var node2 = root.FindOne(new SearcherArgs
            {
                Id = "a4o",
                Text = "搜索或输入网址"
            });
            var node3 = root.FindOne(new SearcherArgs
            {
                Id = "anu",
                Text = "搜索"
            });

            if (node1 is not null)
            {
                Automator.Click(node1.GetBounds().GetCenterX(), node1.GetBounds().GetCenterY());
            }
            else if (node2 is not null && node3 is not null)
            {
                Automator.Click(node2.GetBounds());
                Thread.Sleep(1000);
                node2.SetText("astator");
                Thread.Sleep(1000);
                Automator.Click(node3.GetBounds());
                return;
            }
        }
    }
}
