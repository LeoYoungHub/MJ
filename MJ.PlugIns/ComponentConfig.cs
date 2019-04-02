using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugIn;

namespace MJ.PlugIns
{
    /// <summary>
    /// 组件信息注册类（每一个插件模块必需实现一个ICompoentConfig）
    /// </summary>
    public class CompoentConfig : ICompoentConfig
    {
        public static IAppContext AppContext;

        public void CompoentRegister(IAppContext context, out ICompoent compoent)
        {
            AppContext = context;
            var compoentInfo = new Compoent("MJ.PlugIns", "V1.0");
            compoentInfo.AddFormTypes(typeof(Main), typeof(PowerMgr), typeof(Physics), typeof(Routine), typeof(Treat), typeof(Repair));//将认为需要用到的窗体类型添加到预注册列表中

            compoent = compoentInfo;//回传Compoent的实例
        }
    }
}
