using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InstallPack
{
    public partial class PreLoad : Form
    {
        public PreLoad()
        {
            InitializeComponent();
            //设定图标
            Assembly assembly = Assembly.GetExecutingAssembly();
            BufferedStream iconStream = new BufferedStream(assembly.GetManifestResourceStream("InstallPack.Resources.icon.ico"));
            Icon = new Icon(iconStream);
        }
    }
}
