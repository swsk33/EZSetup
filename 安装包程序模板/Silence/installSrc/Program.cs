using InstallPack.Util;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InstallPack
{
    static class Program
    {
        public static PreLoad preLoad;
        public static MainGUI mainGUI;

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Initialize()
        {
            preLoad.Visible = true;
            Application.DoEvents();
            Directory.CreateDirectory(ConfigUtils.WORK_PLACE);
            if (!Directory.Exists(ConfigUtils.WORK_PLACE))
            {
                MessageBox.Show("初始化失败！请以管理员身份运行此程序重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool extract7z = IOUtils.ExtractFile("InstallPack.Resources.7z.exe", ConfigUtils.WORK_PLACE + "\\7z.exe") && IOUtils.ExtractFile("InstallPack.Resources.7z.dll", ConfigUtils.WORK_PLACE + "\\7z.dll");
            bool extractConf = IOUtils.ExtractFile("InstallPack.Resources.cfg.ezcfg", ConfigUtils.WORK_PLACE + "\\cfg.ezcfg");
            bool extractTool = IOUtils.ExtractFile("InstallPack.Resources.shortcut.exe", ConfigUtils.WORK_PLACE + "\\shortcut.exe");
            bool extractData = IOUtils.ExtractFile("InstallPack.Resources.data.7z", ConfigUtils.WORK_PLACE + "\\data.7z");
            if (!(extract7z && extractConf && extractTool && extractData))
            {
                MessageBox.Show("初始化失败！请以管理员身份运行此程序重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Environment.SetEnvironmentVariable("Path", ConfigUtils.WORK_PLACE + ";" + Environment.GetEnvironmentVariable("Path"));
            preLoad.Visible = false;
            Application.Run(mainGUI);
        }

        /// <summary>
        /// 增加嵌入路径的搜索路径以调用嵌入dll
        /// </summary>
        private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string resourceName = "InstallPack.Resources." + new AssemblyName(args.Name).Name + ".dll";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                byte[] assemblyData = new byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            preLoad = new PreLoad();
            mainGUI = new MainGUI();
            Initialize();
        }
    }
}