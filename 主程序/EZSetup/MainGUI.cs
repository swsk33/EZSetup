using Swsk33.ReadAndWriteSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EZSetup
{
    public partial class MainGUI : Form
    {
        /// <summary>
        /// csc版本
        /// </summary>
        public static Dictionary<string, string> cscVersions = new Dictionary<string, string>();

        public MainGUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 新建临时文件夹
        /// </summary>
        /// <returns>临时文件夹位置</returns>
        private static string createTmpDir()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\swskinsGen_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
            Directory.CreateDirectory(dir);
            return dir;
        }

        private void downSDK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TerminalUtils.RunCommand("cmd", "/c start https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-developer-pack-offline-installer");
        }

        private void MainGUI_Load(object sender, EventArgs e)
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
                foreach (string v in cscVersions.Keys)
                {
                    cscVersionBox.Items.Add(v);
                }
                cscVersionBox.SelectedIndex = 0;
                compressLevelValue.SelectedIndex = 2;
                string[] templates = Directory.GetFiles("TemplatePack");
                foreach (string t in templates)
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

        private void ok_Click(object sender, EventArgs e)
        {
            if (outputPathValue.Text.Equals(""))
            {
                MessageBox.Show("请设定输出路径！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (setIcon.Checked && !File.Exists(iconPath.Text))
            {
                MessageBox.Show("所选图标文件不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (templateList.SelectedIndex < 0)
            {
                MessageBox.Show("请选择安装包模板！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            prepareTip.Visible = true;
            ok.Enabled = false;
            Application.DoEvents();
            string tmpDir = createTmpDir();
            Environment.SetEnvironmentVariable("Path", cscVersions[cscVersionBox.SelectedItem.ToString()] + ";" + Environment.GetEnvironmentVariable("Path"));
            TerminalUtils.RunCommand("Refer\\7z.exe", "x \"TemplatePack\\" + templateList.SelectedItem.ToString() + ".7z\" -o\"" + tmpDir + "\"");
            prepareTip.Visible = false;
            ok.Enabled = true;
            Visible = false;
            string[] runConfig = TerminalUtils.RunCommand(tmpDir + "\\ConfigModule.exe", "");
            if (runConfig[0].StartsWith("0"))
            {
                mainTabPanel.SelectedIndex = 0;
                Visible = true;
            }
            else
            {
                string packedPath = runConfig[0].Substring(0, runConfig[0].LastIndexOf("|"));
                string genUninstall = runConfig[0].Substring(runConfig[0].LastIndexOf("|") + 1);
                string compressLevelArg = "-mx9";
                switch (compressLevelValue.SelectedIndex)
                {
                    case 0:
                        compressLevelArg = "-mx1";
                        break;
                    case 1:
                        compressLevelArg = "-mx3";
                        break;
                    case 2:
                        compressLevelArg = "-mx5";
                        break;
                    case 3:
                        compressLevelArg = "-mx7";
                        break;
                    default:
                        compressLevelArg = "-mx9";
                        break;
                }
                File.Delete(tmpDir + "\\Resources\\data.7z");
                string compressCommandArgs = "a -t7z " + compressLevelArg + " \"" + tmpDir + "\\Resources\\data.7z\" \"" + packedPath + "\\*\"";
                TerminalUtils.RunCommand("7z", compressCommandArgs);
                if (genUninstall.Equals("1"))
                {
                    TerminalUtils.RunCommand("cmd", "/c \"" + tmpDir + "\\build.bat\" u uninstall.exe");
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            mainTabPanel.SelectedIndex++;
        }

        private void setIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (setIcon.Checked)
            {
                iconPath.Enabled = true;
                selectIcon.Enabled = true;
            }
            else
            {
                iconPath.Enabled = false;
                selectIcon.Enabled = false;
            }
        }

        private void selectPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "设定输出文件";
            saveDialog.Filter = "可执行文件|*.exe";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                outputPathValue.Text = saveDialog.FileName;
            }
        }

        private void selectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "选择图标";
            openDialog.Filter = "图标文件|*.ico";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                iconPath.Text = openDialog.FileName;
            }
        }
    }
}