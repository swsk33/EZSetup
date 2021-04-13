using System;
using System.Windows.Forms;

namespace InstallPack.ConfigModule
{
    class Program
    {
        /// <summary>
        /// 状态码，直接关闭而未完成配置则为0，完成配置则为1
        /// </summary>
        public static string code = "0";

        public static MainGUI mainGUI;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            //加入私有路径以搜索dll
            AppDomain.CurrentDomain.AppendPrivatePath("Resources");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainGUI = new MainGUI();
            Application.Run(mainGUI);
            Console.WriteLine(code);
        }
    }
}