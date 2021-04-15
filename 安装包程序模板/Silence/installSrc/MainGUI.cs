using InstallPack.Model;
using InstallPack.Util;
using Newtonsoft.Json;
using Swsk33.ReadAndWriteSharp;
using Swsk33.ReadAndWriteSharp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InstallPack
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化窗体组件
        /// </summary>
        private void initComponent()
        {
            //设定图标
            Assembly assembly = Assembly.GetExecutingAssembly();
            BufferedStream iconStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.icon.ico"));
            Icon = new Icon(iconStream);
            //获取数据
            ConfigUtils.GlobalConfigure = JsonConvert.DeserializeObject<Configure>(File.ReadAllText(ConfigUtils.WORK_PLACE + "\\cfg.ezcfg"));
            
        }

        /**
        private void done_Click(object sender, EventArgs e)
        {
            Hide();
            if (ConfigUtils.GlobalConfigure.OpenAfterSetup && openNow.Checked)
            {
                Process.Start(pathValue.Text + "\\" + ConfigUtils.GlobalConfigure.MainEXE);
            }
            if (!ConfigUtils.GlobalConfigure.RunAfterSetup.Equals(""))
            {
                TerminalUtils.RunCommand("cmd", "/c cd /d \"" + pathValue.Text + "\" && " + ConfigUtils.GlobalConfigure.RunAfterSetup);
            }
            Application.Exit();
        }
        **/

        private void install_Click(object sender, EventArgs e)
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
                    IOUtils.CreateShortcut(originFilePath, destDesktopPath, "");
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title);
                    }
                    string destMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title + "\\" + sitem.Substring(sitem.IndexOf("|") + 1);
                    IOUtils.CreateShortcut(originFilePath, destMenuPath, "");
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
                IOUtils.CreateShortcut(ConfigUtils.GlobalConfigure.InstallPath + "\\uninstall.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title + "\\卸载程序", "");
            }
        }

        private void MainGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Directory.Delete(ConfigUtils.WORK_PLACE, true);
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            initComponent();
        }
    }
}