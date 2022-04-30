using astator.Core.Graphics;
using astator.Core.Script;
using System;
using System.IO;
using System.Threading.Tasks;
using Console = astator.Core.Script.Console;

namespace Examples;

public class GraphicHelperTest
{
    [ScriptEntryMethod(FileName = "09.找图找色.cs")]
    public static async Task Main(ScriptRuntime runtime)
    {
        //注意, 此示例所用到的找图图像和找色比色字符串都需要你重新提供!!!(使用综合图色助手)
        var result = await runtime.PermissionHelper.ReqScreenCapAsync(false);
        if (!result)
        {
            Console.Error("申请截图权限失败!");
            return;
        }

        await Task.Delay(100);
        var helper = GraphicHelper.Create();
        if (helper is null)
        {
            Console.Error("图色帮助类初始化失败!");
            return;
        }

        var sims = new int[] { 85, 90, 95, 98 };

        var image = WrapImage.CreateFromFile(Path.Combine(runtime.WorkDir, "assets", "findImage.png"));
        foreach (var sim in sims)
        {
            var time = DateTime.Now;
            var point = helper.FindImage(0, 0, Devices.Width, Devices.Height, image, sim);
            if (point.X != -1)
            {
                Console.Log($"{sim}相似度找图成功, x:{point.X}, y:{point.Y}");
            }
            Console.Log($"{sim}相似度找图耗时: {(DateTime.Now - time).TotalMilliseconds}毫秒");
        }

        var descStr = "408|2308|0x2f88ff,407|2321|0xf0f3f6,408|2329|0x2f88ff,408|2336|0xf0f3f6,408|2346|0x2f88ff,408|2298|0x333333,438|2335|0x333333,384|2333|0x333333,413|2364|0x333333,956|159|0x333333,963|159|0xd0021b,971|172|0xffffff,977|172|0xd0021b,983|172|0xffffff,990|172|0xd0021b";

        var findColorDesc = helper.ParseFindColorString(descStr);
        foreach (var sim in sims)
        {
            var time = DateTime.Now;
            var point = helper.FindMultiColor(0, 0, Devices.Width, Devices.Height, findColorDesc, sim, false);
            if (point.X != -1)
            {
                Console.Log($"{sim}相似度找色成功, x:{point.X}, y:{point.Y}");
            }
            Console.Log($"{sim}相似度找色耗时: {(DateTime.Now - time).TotalMilliseconds}毫秒");
        }

        var cmpColorDesc = helper.ParseCmpColorString(descStr);
        foreach (var sim in sims)
        {
            var time = DateTime.Now;
            var isMatch = helper.CompareMultiColor(cmpColorDesc, sim, false);
            if (isMatch)
            {
                Console.Log($"{sim}相似度比色成功");
            }
            Console.Log($"{sim}相似度比色耗时: {(DateTime.Now - time).TotalMilliseconds}毫秒");
        }
    }
}
