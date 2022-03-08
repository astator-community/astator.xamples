using astator.Core.Script;

namespace Examples;
public class TabbedPage
{
    [ScriptEntryMethod(FileName = "05.选项卡.cs", IsUIMode = true)]
    public static void Main(ScriptRuntime runtime)
    {
        //tabPage属性: (tabPage继承于frameLayout, 包含一个viewPager和linearLayout)
        //  isBottom: 选项卡是否在底部, 默认true 
        //  tabBg: 导航栏背景颜色
        //  iconShow: 是否展示icon, 默认true
        //  titleShow: 是否展示title,默认true
        //  accrntShow: 是否展示底部提示线,默认true
        //  titleColor: title文本颜色
        //  selectedTitleColor: 选定选项卡title文本颜色
        //  accentColor: 底部提示线背景颜色
        //  accentWidth: 底部提示线宽度

        //tabView属性: (tabView继承于frameLayout)
        //  icon: icon图片路径
        //  selectedIcon: 选定选项卡icon图片路径
        //  title: title文本

        var xml =
        @"
        <linear orientation='vertical'>
        <tabPage weight='1' selectedTitleColor='#2f88ff' tabBg='#f0f3f6' accentWidth='100' accentColor='#2f88ff' iconShow='false'>
            <tabView title='工作台'>
                <text text='样式1-1' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView  title='日志'>
                <text text='样式1-2' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView  title='文档'>
                <text text='样式1-3' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView  title='设置'>
                <text text='样式1-4' textSize='14' layoutGravity='center'/>
            </tabView>
        </tabPage>
        <tabPage weight='1' tabBg='#f0f3f6' accentWidth='14' accentColor='#2f88ff'>
            <tabView icon='home_on.png' title='工作台'>
                <text text='样式2-1' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='log_on.png' title='日志'>
                <text text='样式2-2' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='doc_on.png' title='文档'>
                <text text='样式2-3' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='settings_on.png' title='设置'>
                <text text='样式2-4' textSize='14' layoutGravity='center'/>
            </tabView>
        </tabPage>
        
        <tabPage weight='1' tabBg='#f0f3f6' accentWidth='14' accentColor='#2f88ff' iconShow='true' titleShow='false'>
            <tabView icon='home_on.png' title='工作台'>
                <text text='样式3-1' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='log_on.png' title='日志'>
                <text text='样式3-2' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='doc_on.png' title='文档'>
                <text text='样式3-3' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='settings_on.png' title='设置'>
                <text text='样式3-4' textSize='14' layoutGravity='center'/>
            </tabView>
        </tabPage>

        <tabPage weight='1' tabBg='#f0f3f6' accentWidth='14' accentColor='#2f88ff' accentShow='false' titleShow='false'>
            <tabView icon='home.png' selectedIcon='home_on.png'>
                <text text='样式4-1' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='log.png' selectedIcon='log_on.png'>
                <text text='样式4-2' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='doc.png' selectedIcon='doc_on.png'>
                <text text='样式4-3' textSize='14' layoutGravity='center'/>
            </tabView>
            <tabView icon='settings.png' selectedIcon='settings_on.png'>
                <text text='样式4-4' textSize='14' layoutGravity='center'/>
            </tabView>
        </tabPage>
        </linear>
        ";

        var layout = runtime.Ui.ParseXml(xml);
        runtime.Ui.Show(layout);
    }
}