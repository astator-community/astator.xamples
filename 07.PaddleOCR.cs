using astator.Core.Graphics;
using astator.Core.Script;
using astator.Core.ThirdParty;
using Path = System.IO.Path;

namespace Examples;

public class PaddleOCR
{
    [ScriptEntryMethod(FileName = "07.PaddleOCR.cs")]
    public static void Main(ScriptRuntime runtime)
    {
        var modelDir = Path.Combine(runtime.WorkDir, "assets", "paddleOCR");
        var helper = PaddleOCRHelper.Create(new PaddleOcrArgs(modelDir, Path.Combine(modelDir, "keys.txt")));
        Logger.Log(helper.OCR(WrapImage.CreateFromFile(Path.Combine(modelDir, "test.png"))));
    }
}