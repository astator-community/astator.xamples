using System.IO;
using Android.Graphics;
using astator.Core.Script;
using astator.Core.ThirdParty;
using Java.IO;
using Path = System.IO.Path;

namespace Examples;

public class PaddleOCR
{
    [ScriptEntryMethod(FileName = "06.PaddleOCR.cs")]
    public static void Main(ScriptRuntime runtime)
    {
        var modelDir = Path.Combine(runtime.WorkDir, "assets", "paddleOCR");
        var helper = PaddleOCRHelper.Create(new PaddleOcrArgs(modelDir, Path.Combine(modelDir, "keys.txt")));

        var bitmap = BitmapFactory.DecodeFile(Path.Combine(modelDir, "test.png"));
        ScriptLogger.Log(helper.OCR(bitmap));
        bitmap.Recycle();
    }
}