using InstallPack.Model;
using Newtonsoft.Json;
using Swsk33.ReadAndWriteSharp;
using Swsk33.ReadAndWriteSharp.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InstallPack.ConfigModule
{
	public partial class MainGUI : Form
	{
		public MainGUI()
		{
			InitializeComponent();
		}

		private void MainGUI_Load(object sender, System.EventArgs e)
		{
			//设定图标
			Assembly assembly = Assembly.GetExecutingAssembly();
			BufferedStream iconStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.icon.ico"));
			Icon = new Icon(iconStream);
			//赋初值
			publisherValue.Text = Environment.UserName;
			versionValue.Text = "1.0.0";
		}

		private void selectDir_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "请选择文件夹路径";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				dirValue.Text = dialog.SelectedPath;
			}
		}

		private void selectExe_Click(object sender, System.EventArgs e)
		{
			if (!Directory.Exists(dirValue.Text))
			{
				MessageBox.Show("待打包文件夹未选择或者不存在！请先选择待打包文件夹！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				OpenFileDialog dialog = new OpenFileDialog();
				dialog.Multiselect = false;
				dialog.InitialDirectory = dirValue.Text;
				dialog.Title = "请选择文件";
				dialog.Filter = "所有文件(*.*)|*.*";
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					mainExeValue.Text = dialog.FileName.Substring(dialog.FileName.LastIndexOf("\\") + 1);
				}
			}
		}

		private void generateShortcut_CheckedChanged(object sender, System.EventArgs e)
		{
			if (generateShortcut.Checked)
			{
				clear.Enabled = true;
				add.Enabled = true;
				remove.Enabled = true;
				shortcutList.Enabled = true;
			}
			else
			{
				clear.Enabled = false;
				add.Enabled = false;
				remove.Enabled = false;
				shortcutList.Enabled = false;
			}
		}

		private void selectInstallPath_Click(object sender, System.EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "请选择默认安装路径";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				installPathValue.Text = dialog.SelectedPath;
			}
		}

		private void clear_Click(object sender, System.EventArgs e)
		{
			shortcutList.Items.Clear();
		}

		private void add_Click(object sender, System.EventArgs e)
		{
			if (!Directory.Exists(dirValue.Text))
			{
				MessageBox.Show("待打包文件夹未选择或者不存在！请先选择待打包文件夹！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				new ShortcutInfo().ShowDialog();
			}
		}

		private void remove_Click(object sender, System.EventArgs e)
		{
			if (shortcutList.SelectedIndex >= 0)
			{
				shortcutList.Items.RemoveAt(shortcutList.SelectedIndex);
			}
		}

		private void done_Click(object sender, System.EventArgs e)
		{
			//查错
			if (titleValue.Text.Equals(""))
			{
				MessageBox.Show("请填写软件名！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (dirValue.Text.Equals(""))
			{
				MessageBox.Show("请填写待打包文件夹！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Directory.Exists(dirValue.Text))
			{
				MessageBox.Show("打包文件夹不存在！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (generateShortcut.Checked && shortcutList.Items.Count == 0)
			{
				MessageBox.Show("请指定要创建快捷方式的文件或者取消勾选创建快捷方式！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (installPathValue.Text.Equals(""))
			{
				MessageBox.Show("请填写默认安装路径！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (publisherValue.Text.Equals(""))
			{
				MessageBox.Show("请填写发布者！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (versionValue.Text.Equals(""))
			{
				MessageBox.Show("请填写版本号！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//写入配置文件
			Configure cfg = new Configure();
			cfg.Title = titleValue.Text;
			cfg.PackedDir = dirValue.Text;
			cfg.MainEXE = mainExeValue.Text;
			cfg.GenerateShortcut = generateShortcut.Checked;
			List<string> shortcuts = new List<string>();
			foreach (string item in shortcutList.Items)
			{
				shortcuts.Add(item);
			}
			cfg.ShortcutList = shortcuts;
			cfg.InstallPath = installPathValue.Text;
			cfg.AddBootOption = addBootOption.Checked;
			cfg.RunAfterSetup = runafterValue.Text;
			cfg.RunBeforeUnSetup = runBeforeUnValue.Text;
			cfg.OpenAfterSetup = openAfterSetup.Checked;
			cfg.GenerateUninstall = genUnsetup.Checked;
			cfg.ShowInstallProcess = showInstallWindow.Checked;
			cfg.Publisher = publisherValue.Text;
			cfg.Version = versionValue.Text;
			string currentDir = AppDomain.CurrentDomain.BaseDirectory;
			if (!Directory.Exists(currentDir + "\\Resources"))
			{
				Directory.CreateDirectory(currentDir + "\\Resources");
			}
			string cfgJson = JsonConvert.SerializeObject(cfg);
			File.WriteAllText(currentDir + @"\Resources\cfg.ezcfg", cfgJson);
			string uninstallCode;
			if (cfg.GenerateUninstall)
			{
				uninstallCode = "1";
			}
			else
			{
				uninstallCode = "0";
			}
			Program.code = cfg.PackedDir + "|" + uninstallCode;
			Close();
		}

		private void genUnsetup_CheckedChanged(object sender, EventArgs e)
		{
			if (genUnsetup.Checked)
			{
				runBeforeUnValue.Enabled = true;
			}
			else
			{
				runBeforeUnValue.Enabled = false;
			}
		}

		private void titleValue_TextChanged(object sender, EventArgs e)
		{
			installPathValue.Text = @"D:\Program Files\" + titleValue.Text;
		}
	}
}