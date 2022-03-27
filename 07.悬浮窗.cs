using System;
using System.IO;
using Android.Graphics;
using astator.Core.Script;
using astator.Core.ThirdParty;
using astator.Core.UI.Base;
using astator.Core.UI.Floaty;
using Java.IO;
using Path = System.IO.Path;
using Examples.Core;

namespace Examples;

public class FloatyTest
{


    [ScriptEntryMethod(FileName = "07.悬浮窗.cs", IsUIMode = true)]
    public static void Main(ScriptRuntime runtime)
    {
        Runtime.Instance = runtime;
        var ui = @"
        <linear orientation='vertical'>
            <card bg='#444f7d'>
                <text margin='10,0' h='60' text='悬浮窗' textColor='#000000' textSize='22' textStyle='bold' gravity='center'/>
            </card>
            <linear orientation='vertical'>
                <btn id='show' text='显示悬浮窗' margin='20,5'/>
                <btn id='remove' text='移除悬浮窗'  margin='20,5'/>
                <btn id='setPosition' text='设置位置'  margin='20,5'/>
            </linear>
        </linear>";

        Runtime.Ui.Show(Runtime.Ui.ParseXml(ui));

        SystemFloatyWindow floatyWindow = null;

        Runtime.Ui["show"].On("click", new OnClickListener((v) =>
        {
            if (!Runtime.PermissionHelper.CheckFloaty())
            {
                Runtime.PermissionHelper.ReqFloaty();
                return;
            }
            else
            {
                floatyWindow?.Remove();
                floatyWindow = null;

                var xml = @"
                <frame bg='#00ffffff'>
                    <img w='40' h='40' radius='20' src='appicon.png'/>
                </frame>
                ";

                var manager = Runtime.FloatyHelper.CreateFloatyManager();
                var view = manager.ParseXml(xml);
                floatyWindow = manager.CreateSystemFloaty(view);
                floatyWindow.Show();
            }
        }));

        Runtime.Ui["remove"].On("click", new OnClickListener((v) =>
        {
            floatyWindow?.Remove();
            floatyWindow = null;
        }));

        Runtime.Ui["setPosition"].On("click", new OnClickListener((v) =>
        {
            if (floatyWindow is not null)
            {
                var x = new Random().Next(390);
                var y = new Random().Next(690);
                floatyWindow?.SetPosition(x, y);
            }

        }));

    }


}