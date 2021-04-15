using System.Diagnostics;
using System.Windows.Forms;

namespace EZSetup
{
    public partial class ProcessForm : Form
    {
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
    }
}
