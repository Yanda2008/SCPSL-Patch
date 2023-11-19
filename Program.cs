using System;
using System.Windows.Forms;

namespace _string防踢补丁
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HostsEditor.Form1()); // 注意这里的命名空间和类名
        }
    }
}
