using System;       
using astator.Core;      
using astator.Core.Script;

namespace Examples;
public class HelloWorld
{
    [ScriptEntryMethod(FileName = "1.HelloWorld.cs")]
    public static void Main(ScriptRuntime runtime)
    {
        Console.WriteLine("hello world");
        Globals.Toast("hello world");
    }
}
