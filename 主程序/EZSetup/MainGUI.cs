using Swsk33.ReadAndWriteSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                Visible = false;
                ProcessForm form = new ProcessForm();
                form.Show();
                Application.DoEvents();
                form.dir = outputPathValue.Text.Substring(0, outputPathValue.Text.LastIndexOf("\\"));
                string packedPath = runConfig[0].Substring(0, runConfig[0].LastIndexOf("|"));
                string genUninstall = runConfig[0].Substring(runConfig[0].LastIndexOf("|") + 1);
                if (setIcon.Checked)
                {
                    File.Copy(iconPath.Text, tmpDir + "\\Resources\\icon.ico", true);
                }
                string compressLevelArg;
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
                string compressCommandArgs = "a -y -t7z " + compressLevelArg + " \"" + tmpDir + "\\Resources\\data.7z\" \"" + packedPath + "\\*\"";
                TerminalUtils.RunCommand("Refer\\7z", compressCommandArgs);
                form.progressBar.Value = 75;
                Application.DoEvents();
                if (genUninstall.StartsWith("1") && !File.Exists(packedPath + "\\uninstall.exe"))
                {
                    TerminalUtils.RunCommand(tmpDir + "\\build.bat", "u uninstall.exe");
                    TerminalUtils.RunCommand("Refer\\7z", "a -y " + "\"" + tmpDir + "\\Resources\\data.7z\" \"" + tmpDir + "\\uninstall.exe\"");
                }
                form.progressBar.Value = 90;
                Application.DoEvents();
                TerminalUtils.RunCommand(tmpDir + "\\build.bat", "i \"" + outputPathValue.Text + "\"");
                form.progressBar.Value = 100;
                Application.DoEvents();
                if (File.Exists(outputPathValue.Text))
                {
                    form.processingTip.Text = "构建完成！";
                    form.processingTip.ForeColor = Color.Green;
                    form.close.Enabled = true;
                    form.openDir.Enabled = true;
                }
                else
                {
                    form.processingTip.Text = "构建失败！";
                    form.processingTip.ForeColor = Color.Red;
                    form.close.Enabled = true;
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

        private void refer7z_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TerminalUtils.RunCommand("cmd", "/c start https://www.7-zip.org/");
        }

        private void referNewSoftJson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TerminalUtils.RunCommand("cmd", "/c start https://www.newtonsoft.com/json");
        }
    }
}