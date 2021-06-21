using System.Diagnostics;
using System.Windows.Forms;

namespace EZSetup
{
	public partial class ProcessForm : Form
	{
		/// <summary>
		/// 鼠标按下时在窗口中的x坐标
		/// </summary>
		private int mouseAtX;

		/// <summary>
		/// 鼠标按下时在窗口中的y坐标
		/// </summary>
		private int mouseAtY;

		/// <summary>
		/// 鼠标是否在窗口上是按下状态
		/// </summary>
		private bool isMouseDown = false;

		public ProcessForm()
		{
			InitializeComponent();
		}

		public string dir;

		private void close_Click(object sender, System.EventArgs e)
		{
			Close();
			Program.mainGUI.Visible = true;
			Program.mainGUI.mainTabPanel.SelectedIndex = 0;
		}

		private void openDir_Click(object sender, System.EventArgs e)
		{
			Process.Start(dir);
			Close();
			Program.mainGUI.Visible = true;
			Program.mainGUI.mainTabPanel.SelectedIndex = 0;
		}

		private void ProcessForm_MouseDown(object sender, MouseEventArgs e)
		{
			Cursor = Cursors.Cross;
			mouseAtX = e.X;
			mouseAtY = e.Y;
			isMouseDown = true;
		}

		private void ProcessForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseDown)
			{
				Left = MousePosition.X - mouseAtX;
				Top = MousePosition.Y - mouseAtY;
			}
		}

		private void ProcessForm_MouseUp(object sender, MouseEventArgs e)
		{

			Cursor = Cursors.Default;
			isMouseDown = false;
		}
	}
}