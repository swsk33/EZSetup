using InstallPack.Util;
using System;
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
            //设定图标
            Assembly assembly = Assembly.GetExecutingAssembly();
            BufferedStream iconStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.icon.ico"));
            Icon = new Icon(iconStream);
        }

        private void MainGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Directory.Delete(ConfigUtils.WORK_PLACE, true);
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            initComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            BufferedStream gifStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.installing.gif"));
            installingGif.Image = Image.FromStream(gifStream);
        }
    }
}