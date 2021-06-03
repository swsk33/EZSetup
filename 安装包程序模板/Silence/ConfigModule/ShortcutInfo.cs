using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InstallPack.ConfigModule
{
	public partial class ShortcutInfo : Form
	{
		public ShortcutInfo()
		{
			InitializeComponent();
		}

		private void selectOriginFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Multiselect = false;
			dialog.Title = "请选择文件";
			dialog.Filter = "所有文件(*.*)|*.*";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string originFileName = dialog.FileName.Substring(dialog.FileName.LastIndexOf("\\") + 1);
				string shortcutName;
				if (originFileName.Contains("."))
				{
					shortcutName = originFileName.Substring(0, originFileName.LastIndexOf("."));
				}
				else
				{
					shortcutName = originFileName;
				}
				originFileValue.Text = originFileName;
				shortcutNameValue.Text = shortcutName;
			}
		}

		private void ok_Click(object sender, EventArgs e)
		{
			if (originFileValue.Text.Equals("") || shortcutNameValue.Text.Equals(""))
			{
				MessageBox.Show("快捷方式原文件或者快捷方式名不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			string addValue;
			if (argsValue.Text.Equals(""))
			{
				addValue = originFileValue.Text + "|" + shortcutNameValue.Text;
			}
			else
			{
				addValue = originFileValue.Text + "|" + shortcutNameValue.Text + "|" + argsValue.Text;
			}
			Program.mainGUI.shortcutList.Items.Add(addValue);
			Close();
		}

		private void ShortcutInfo_Load(object sender, EventArgs e)
		{
			//设定图标
			Assembly assembly = Assembly.GetExecutingAssembly();
			BufferedStream iconStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.icon.ico"));
			Icon = new Icon(iconStream);
		}
	}
}