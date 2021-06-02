using System;
using System.Windows.Forms;

namespace EZSetup
{
	public partial class FailedInfo : Form
	{
		public FailedInfo()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 用指定的内容初始化一个错误信息窗口
		/// </summary>
		/// <param name="stdOut">填入标准输出信息以显示在内容框</param>
		/// <param name="stdErr">填入标准错误信息以显示在内容框</param>
		public void InitContent(string stdOut, string stdErr)
		{
			stdOutValue.Text = stdOut;
			stdErrValue.Text = stdErr;
			Show();
		}

		private void close_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
