using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppHandleMessage
{
    public class ControlSet
    {
        public static IntPtr MainFormHandle { get; set; }
        public static Form MainForm { get; set; }

        //若有多个需要传输消息的控件或form需以静态的方式注册到ControlSet中
        public static IntPtr ResultViewCtrl { get; set; }
    }
}
