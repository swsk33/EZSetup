using System;
using System.Windows.Forms;

namespace EZSetup
{
	static class Program
	{
		public static MainGUI mainGUI;

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		[Obsolete]
		static void Main()
		{
			AppDomain.CurrentDomain.AppendPrivatePath("lib"); //设定dll检索路径
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			mainGUI = new MainGUI();
			Application.Run(mainGUI);
		}
	}
}