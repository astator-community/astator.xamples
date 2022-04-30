using astator.Core.Script;
using System.Threading.Tasks;
using Console = astator.Core.Script.Console;

namespace Examples;

public class ConsoleTest
{
    [ScriptEntryMethod(FileName = "02.控制台.cs")]
    public async static Task Main(ScriptRuntime runtime)
    {
        //开启控制台
        await Console.ShowAsync(width: 300, height: 390);

        Console.SetLogLevelColors(trace: "#422517", debug: "#a76283", info: "#107c10", wran: "#b4884d", error: "#c12c1f", fatal: "#e60012");
        Console.Trace("trace");
        Console.Debug("log");
        Console.Info("Info");
        Console.Warn("warn");
        Console.Error("error");
        Console.Fatal("fatal");

        while (true)
        {
            Console.Trace("输入exit退出脚本, 输入cls清空控制台");
            var input = await Console.ReadInputAsync(60000);
            if (input == "exit")
            {
                break;
            }
            else if (input == "cls")
            {
                Console.Clear();
            }
        }
        //关闭控制台
        Console.Close();
    }
}
