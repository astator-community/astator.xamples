using astator.Core.Script;
using Console = astator.Core.Script.Console;

namespace Examples;
public class UsingNugetPackage
{
    [ScriptEntryMethod(FileName = "03.引用nuget包.cs")]
    public static void Main(ScriptRuntime runtime)
    {
        //我们在csproj引用了一个Serilog的nuget包, 简单获取它某个类的全名
        Console.WriteLine($"class<Logger> fullName: {typeof(Serilog.Core.Logger).FullName}");
        Globals.Toast($"class<Logger> fullName: {typeof(Serilog.Core.Logger).FullName}");
    }
}
