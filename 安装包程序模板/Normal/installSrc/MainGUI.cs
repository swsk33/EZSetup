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
			//禁用关闭按钮
			ControlBox = false;
			//设定图标
			Assembly assembly = Assembly.GetExecutingAssembly();
			BufferedStream iconStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.icon.ico"));
			Icon = new Icon(iconStream);
			//获取数据
			ConfigUtils.GlobalConfigure = JsonConvert.DeserializeObject<Configure>(File.ReadAllText(ConfigUtils.WORK_PLACE + "\\cfg.ezcfg"));
			Text = ConfigUtils.GlobalConfigure.Title + " 安装程序";
			title.Text = "欢迎使用" + ConfigUtils.GlobalConfigure.Title + "安装向导";
			licenseContent.Text = ConfigUtils.GlobalConfigure.License;
			pathValue.Text = ConfigUtils.GlobalConfigure.InstallPath;
			addDesktopIcon.Visible = ConfigUtils.GlobalConfigure.GenerateShortcut;
			addBootOption.Visible = ConfigUtils.GlobalConfigure.AddBootOption;
			openNow.Visible = ConfigUtils.GlobalConfigure.OpenAfterSetup;
		}
		private void exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void browse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			dialog.Description = "请选择安装路径";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				pathValue.Text = dialog.SelectedPath;
			}
		}

		private void agree_CheckedChanged(object sender, EventArgs e)
		{
			if (agree.Checked)
			{
				licensePageNext.Enabled = true;
			}
			else
			{
				licensePageNext.Enabled = false;
			}
		}

		private void initPageNext_Click(object sender, EventArgs e)
		{
			mainTabPanel.SelectedIndex = 1;
		}

		private void licensePageNext_Click(object sender, EventArgs e)
		{
			mainTabPanel.SelectedIndex = 2;
		}

		private void licensePageLast_Click(object sender, EventArgs e)
		{
			mainTabPanel.SelectedIndex = 0;
		}

		private void configPageLast_Click(object sender, EventArgs e)
		{
			mainTabPanel.SelectedIndex = 1;
		}

		private void done_Click(object sender, EventArgs e)
		{
			Hide();
			Environment.CurrentDirectory = pathValue.Text;
			if (ConfigUtils.GlobalConfigure.OpenAfterSetup && openNow.Checked)
			{
				Process.Start(ConfigUtils.GlobalConfigure.MainEXE);
			}
			if (!ConfigUtils.GlobalConfigure.RunAfterSetup.Equals(""))
			{
				if (ConfigUtils.GlobalConfigure.RunAfterSetup.Contains(" "))
				{
					string command = ConfigUtils.GlobalConfigure.RunAfterSetup.Substring(0, ConfigUtils.GlobalConfigure.RunAfterSetup.IndexOf(" "));
					string args = ConfigUtils.GlobalConfigure.RunAfterSetup.Substring(ConfigUtils.GlobalConfigure.RunAfterSetup.IndexOf(" ") + 1);
					TerminalUtils.RunCommand(command, args);
				}
				else
				{
					Process.Start(ConfigUtils.GlobalConfigure.RunAfterSetup);
				}
			}
			Application.Exit();
		}

		private void install_Click(object sender, EventArgs e)
		{
			if (pathValue.Text.Equals(""))
			{
				MessageBox.Show("安装目录不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Directory.Exists(pathValue.Text.Substring(0, 3)))
			{
				MessageBox.Show("指定的安装目录所在驱动器不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Directory.Exists(pathValue.Text) && (Directory.GetFiles(pathValue.Text).Length != 0 || Directory.GetDirectories(pathValue.Text).Length != 0))
			{
				MessageBox.Show("指定的安装目录必须为空目录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			//开始执行安装
			mainTabPanel.SelectedIndex = 3;
			if (!Directory.Exists(pathValue.Text))
			{
				Directory.CreateDirectory(pathValue.Text);
			}
			long totalSize = IOUtils.Get7zOriginSize(ConfigUtils.WORK_PLACE + "\\data.7z");
			TerminalResult result = new TerminalResult();
			TerminalUtils.RunCommandAsynchronously("7z", "x " + TextUtils.SurroundByDoubleQuotes(ConfigUtils.WORK_PLACE + "\\data.7z") + " -o" + TextUtils.SurroundByDoubleQuotes(pathValue.Text), result);
			int ratio = 0;
			string curFile;
			while (!result.Finished)
			{
				try
				{
					DirInfo info = new DirInfo();
					BinaryUtils.GetDirectoryInfo(pathValue.Text, info);
					ratio = (int)((float)info.Size / totalSize * 100);
					if (ratio > 100)
					{
						ratio = 100;
					}
					List<string> fileList = info.FileList;
					if (fileList.Count > 0)
					{
						curFile = fileList[fileList.Count - 1];
						currentFile.Text = "正在释放：" + curFile.Substring(curFile.LastIndexOf("\\") + 1);
					}
				}
				catch
				{
					//none
				}
				finally
				{
					processValue.Text = ratio + "%";
					progressBar.Value = ratio;
					Application.DoEvents();
				}
			}
			//安装完成，写入相应注册表和创建快捷方式
			if (ConfigUtils.GlobalConfigure.GenerateShortcut && addDesktopIcon.Checked)
			{
				foreach (string sitem in ConfigUtils.GlobalConfigure.ShortcutList)
				{
					string[] shortInfo = sitem.Split('|'); //分割后得到分别是原文件名、快捷方式名和运行参数（可能没有参数）
					string originFilePath = pathValue.Text + "\\" + shortInfo[0];
					string destDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + shortInfo[1];
					if (shortInfo.Length == 2)
					{
						IOUtils.CreateShortcut(originFilePath, destDesktopPath);
					}
					else
					{
						IOUtils.CreateShortcut(originFilePath, destDesktopPath, shortInfo[2]);
					}
					if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title))
					{
						Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title);
					}
					string destMenuPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title + "\\" + shortInfo[1];
					if (shortInfo.Length == 2)
					{
						IOUtils.CreateShortcut(originFilePath, destMenuPath);
					}
					else
					{
						IOUtils.CreateShortcut(originFilePath, destMenuPath, shortInfo[2]);
					}
				}
			}
			if (ConfigUtils.GlobalConfigure.AddBootOption && addBootOption.Checked)
			{
				RegUtils.OperateBootOption(ConfigUtils.GlobalConfigure.Title, pathValue.Text + "\\" + ConfigUtils.GlobalConfigure.MainEXE, true);
			}
			//如果生成卸载程序，则加入注册表程序信息
			if (ConfigUtils.GlobalConfigure.GenerateUninstall)
			{
				AppUninstallInfo info = new AppUninstallInfo();
				info.DisplayName = ConfigUtils.GlobalConfigure.Title;
				info.InstallPath = pathValue.Text;
				info.UninstallString = pathValue.Text + "\\uninstall.exe";
				string iconPath = ConfigUtils.GlobalConfigure.MainEXE;
				if (iconPath.Equals(""))
				{
					iconPath = "uninstall.exe";
				}
				info.DisplayIcon = pathValue.Text + "\\" + iconPath;
				info.EstimatedSize = totalSize / 1024;
				info.DisplayVersion = ConfigUtils.GlobalConfigure.Version;
				info.Publisher = ConfigUtils.GlobalConfigure.Publisher;
				RegUtils.OperateAppUninstallItem(info, true);
				if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title))
				{
					Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title);
				}
				IOUtils.CreateShortcut(pathValue.Text + "\\uninstall.exe", Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms) + "\\" + ConfigUtils.GlobalConfigure.Title + "\\卸载程序");
			}
			mainTabPanel.SelectedIndex = 4;
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