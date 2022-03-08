using System;
using System.Threading;
using astator.Core.Script;

namespace Examples;
public class HelloWorld
{
    [ProjectEntryMethod]
    public static void ProjectMain(ScriptRuntime runtime)
    {
        Console.WriteLine("hello world 1");
        Globals.Toast("hello world 1");
    }

    [ScriptEntryMethod(FileName = "01.HelloWorld.cs")]
    public static void ScriptMain(ScriptRuntime runtime)
    {
        Console.WriteLine("hello world 2");
        Globals.Toast("hello world 2");
    }
}
