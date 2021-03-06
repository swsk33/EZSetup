using InstallPack.Model;
using Newtonsoft.Json;
using Swsk33.ReadAndWriteSharp;
using Swsk33.ReadAndWriteSharp.Model;
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

		private static string selfPath = Process.GetCurrentProcess().MainModule.FileName;

		private static string appPath = selfPath.Substring(0, selfPath.LastIndexOf("\\"));

		/// <summary>
		/// 释放内嵌资源至指定位置
		/// </summary>
		/// <param name="resource">嵌入的资源，此参数写作：命名空间.文件夹名.文件名.扩展名</param>
		/// <param name="path">释放到位置</param>
		/// <returns>是否释放成功</returns>
		public static bool ExtractFile(string resource, string path)
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
			Directory.Delete(WORK_PLACE, true);
			Application.Exit();
		}

		private void ok_Click(object sender, EventArgs e)
		{
			uninstalling.Visible = true;
			ok.Enabled = false;
			cancel.Enabled = false;
			Configure cfg = JsonConvert.DeserializeObject<Configure>(File.ReadAllText(WORK_PLACE + "\\cfg.ezcfg"));
			if (!cfg.RunBeforeUnSetup.Equals(""))
			{
				state.Text = "执行卸载前命令...";
				Application.DoEvents();
				Environment.CurrentDirectory = appPath;
				string totalCommand = cfg.RunBeforeUnSetup;
				if (totalCommand.Contains(" "))
				{
					string command = totalCommand.Substring(0, totalCommand.IndexOf(" "));
					string args = totalCommand.Substring(totalCommand.IndexOf(" ") + 1);
					TerminalUtils.RunCommand(command, args);
				}
				else
				{
					Process.Start(totalCommand);
				}
			}
			if (cfg.GenerateShortcut)
			{
				state.Text = "移除快捷方式...";
				Application.DoEvents();
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
			if (cfg.AddBootOption)
			{
				state.Text = "移除开机启动项...";
				Application.DoEvents();
				RegUtils.OperateBootOption(cfg.Title, "", false);
			}
			state.Text = "移除程序信息注册表...";
			Application.DoEvents();
			RegUtils.OperateAppUninstallItem(new AppUninstallInfo(cfg.Title, ""), false);
			state.Text = "移除文件...";
			Application.DoEvents();
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
			state.Text = "程序目录：" + appPath;
		}
	}
}