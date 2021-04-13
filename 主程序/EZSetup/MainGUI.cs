using Swsk33.ReadAndWriteSharp;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EZSetup
{
    public partial class MainGUI : Form
    {
        public static Dictionary<string, string> cscVersions = new Dictionary<string, string>();

        public MainGUI()
        {
            InitializeComponent();
        }

        private void downSDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TerminalUtils.RunCommand("cmd", "/c start https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer");
        }

        private void MainGUI_Load(object sender, System.EventArgs e)
        {
            //检测编译环境
            string[] netDirs = Directory.GetDirectories(@"C:\Windows\Microsoft.NET\Framework");
            foreach (string dir in netDirs)
            {
                if (File.Exists(dir + "\\csc.exe"))
                {
                    string version = dir.Substring(dir.LastIndexOf("\\") + 1);
                    cscVersions.Add(version, dir);
                }
            }
            if (cscVersions.Count == 0)
            {
                sdkNotFoundTip.Visible = true;
                downSDK.Visible = true;
                next.Enabled = false;
            }
            else
            {
                foreach(string v in cscVersions.Keys)
                {
                    cscVersionBox.Items.Add(v);
                }
                cscVersionBox.SelectedIndex = 0;
                string[] templates = Directory.GetFiles("TemplatePack");
                foreach(string t in templates)
                {
                    if (t.EndsWith(".7z"))
                    {
                        string tem = t.Substring(t.LastIndexOf("\\") + 1);
                        tem = tem.Substring(0, tem.LastIndexOf("."));
                        templateList.Items.Add(tem);
                    }
                }
            }
        }
    }
}
