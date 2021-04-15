using InstallPack.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace InstallPack.UninstallModule
{
    public partial class MainGUI : Form
    {
        private static readonly string WORK_PLACE = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\swskun_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

        /// <summary>
        /// 释放内嵌资源至指定位置
        /// </summary>
        /// <param name="resource">嵌入的资源，此参数写作：命名空间.文件夹名.文件名.扩展名</param>
        /// <param name="path">释放到位置</param>
        /// <returns>是否释放成功</returns>
        public static bool ExtractFile(String resource, String path)
        {
            bool result = false;
            Assembly assembly = Assembly.GetExecutingAssembly();
            BufferedStream input = new BufferedStream(assembly.GetManifestResourceStream(resource));
            FileStream output = new FileStream(path, FileMode.Create);
            byte[] data = new byte[1024];
            int lengthEachRead;
            while ((lengthEachRead = input.Read(data, 0, data.Length)) > 0)
            {
                output.Write(data, 0, lengthEachRead);
            }
            output.Flush();
            output.Close();
            if (File.Exists(path))
            {
                result = true;
            }
            return result;
        }

        public MainGUI()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            uninstalling.Visible = true;
            ok.Enabled = false;
            cancel.Enabled = false;
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            string selfPath = Process.GetCurrentProcess().MainModule.FileName;
            if (appPath.EndsWith("\\"))
            {
                appPath = appPath.Substring(0, appPath.Length - 1);
            }
            Configure cfg = JsonConvert.DeserializeObject<Configure>(File.ReadAllText(WORK_PLACE + "\\cfg.ezcfg"));
            if (cfg.GenerateShortcut)
            {
                try
                {
                    if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + cfg.Title))
                    {
                        Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + cfg.Title, true);
                    }
                    if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + cfg.Title + ".lnk"))
                    {
                        File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + cfg.Title + ".lnk");
                    }
                }
                catch
                {
                    //none
                }
            }
            RegistryKey mainKey = Registry.LocalMachine;
            if (cfg.AddBootOption)
            {
                RegistryKey bootOptionKey = mainKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                try
                {
                    bootOptionKey.DeleteValue(cfg.Title);
                }
                catch
                {
                    //none
                }
                finally
                {
                    bootOptionKey.Close();
                }
            }
            RegistryKey appInfoKey = mainKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", true);
            try
            {
                appInfoKey.DeleteSubKeyTree(cfg.Title);
            }
            catch
            {
                //none
            }
            finally
            {
                appInfoKey.Close();
            }
            string[] dirList = Directory.GetDirectories(appPath);
            string[] fileList = Directory.GetFiles(appPath);
            foreach (string dir in dirList)
            {
                try
                {
                    Directory.Delete(dir, true);
                }
                catch
                {
                    //none
                }
            }
            foreach (string file in fileList)
            {
                if (!file.Equals(selfPath))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch
                    {
                        //none
                    }
                }
            }
            File.WriteAllText(WORK_PLACE + "\\delete.vbs", "wscript.sleep 1000*1\r\nset f=createobject(\"Scripting.FileSystemObject\")\r\nf.DeleteFolder(\"" + appPath + "\"),true\r\nf.DeleteFolder(\"" + WORK_PLACE + "\"),true\r\ncall MsgBox(\"卸载成功！\", 64, \"完成\")", Encoding.GetEncoding("gbk"));
            Process.Start(WORK_PLACE + "\\delete.vbs");
            Application.Exit();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            //设定图标
            Assembly assembly = Assembly.GetExecutingAssembly();
            BufferedStream iconStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.icon.ico"));
            Icon = new Icon(iconStream);
            if (!Directory.Exists(WORK_PLACE))
            {
                Directory.CreateDirectory(WORK_PLACE);
            }
            ExtractFile("InstallPack.Resources.cfg.ezcfg", WORK_PLACE + "\\cfg.ezcfg");
        }
    }
}