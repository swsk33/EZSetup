using System;
using System.Windows.Forms;

namespace EZSetup
{
	static class Program
	{
		public static MainGUI mainGUI;

		/// <summary>
		/// 应用程序的主入口点
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			mainGUI = new MainGUI();
			Application.Run(mainGUI);
		}
	}
}