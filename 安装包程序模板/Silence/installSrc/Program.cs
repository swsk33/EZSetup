using InstallPack.Model;
using InstallPack.Util;
using Newtonsoft.Json;
using Swsk33.ReadAndWriteSharp;
using Swsk33.ReadAndWriteSharp.Model;
using System;
using System.Diagnostics;
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
            //获取数据
            ConfigUtils.GlobalConfigure = JsonConvert.DeserializeObject<Configure>(File.ReadAllText(ConfigUtils.WORK_PLACE + "\\cfg.ezcfg"));
            if (ConfigUtils.GlobalConfigure.ShowInstallProcess)
            {
                mainGUI.Visible = true;
                Application.DoEvents();
            }
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
        /// 安装时执行
        /// </summary>
        public static void DoInstall()
        {
            //开始执行安装
            if (!Directory.Exists(ConfigUtils.GlobalConfigure.InstallPath))
            {
                Directory.CreateDirectory(ConfigUtils.GlobalConfigure.InstallPath);
            }
            long totalSize = ConfigUtils.GlobalConfigure.PackedDirSize;
            TerminalResult result = new TerminalResult();
            TerminalUtils.RunCommandAsynchronously("7z", "x \"" + ConfigUtils.WORK_PLACE + "\\data.7z\" -o\"" + ConfigUtils.GlobalConfigure.InstallPath + "\"", result);
            //安装完成，写入相应注册表和创建快捷方式
            if (ConfigUtils.GlobalConfigure.GenerateShortcut)
            {
                foreach (string sitem in ConfigUtils.GlobalConfigure.ShortcutList)
                {
                    string originFilePath = ConfigUtils.GlobalConfigure.InstallPath + "\\" + sitem.Substring(0, sitem.IndexOf("|"));
                    string destDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + sitem.Substring(sitem.IndexOf("|") + 1);
                    IOUtils.CreateShortcut(originFilePath, destDesktopPath);
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title);
                    }
                    string destMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title + "\\" + sitem.Substring(sitem.IndexOf("|") + 1);
                    IOUtils.CreateShortcut(originFilePath, destMenuPath);
                }
            }
            if (ConfigUtils.GlobalConfigure.AddBootOption)
            {
                IOUtils.AddBootOption(ConfigUtils.GlobalConfigure.Title, ConfigUtils.GlobalConfigure.InstallPath + "\\" + ConfigUtils.GlobalConfigure.MainEXE);
            }
            //如果生成卸载程序，则加入注册表程序信息
            if (ConfigUtils.GlobalConfigure.GenerateUninstall)
            {
                IOUtils.AddUninstallInfo(ConfigUtils.GlobalConfigure.Title, ConfigUtils.GlobalConfigure.InstallPath, ConfigUtils.GlobalConfigure.MainEXE, "uninstall.exe");
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title))
                {
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title);
                }
                IOUtils.CreateShortcut(ConfigUtils.GlobalConfigure.InstallPath + "\\uninstall.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title + "\\卸载程序");
            }
        }

        /// <summary>
        /// 安装后执行
        /// </summary>
        public static void DoAfterInstall()
        {
            Environment.CurrentDirectory = ConfigUtils.GlobalConfigure.InstallPath;
            if (ConfigUtils.GlobalConfigure.OpenAfterSetup)
            {
                Process.Start(ConfigUtils.GlobalConfigure.InstallPath + "\\" + ConfigUtils.GlobalConfigure.MainEXE);
            }
            if (!ConfigUtils.GlobalConfigure.RunAfterSetup.Equals(""))
            {
                TerminalUtils.RunCommand("cmd", "/c cd /d \"" + ConfigUtils.GlobalConfigure.InstallPath + "\" && " + ConfigUtils.GlobalConfigure.RunAfterSetup);
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
            DoInstall();
            DoAfterInstall();
        }
    }
}