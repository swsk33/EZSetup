using System.Collections.Generic;

namespace InstallPack.Model
{
    class Configure
    {
        /// <summary>
        /// 标题
        /// </summary>
        private string title;

        /// <summary>
        /// 协议内容
        /// </summary>
        private string license;

        /// <summary>
        /// 是否生成快捷方式
        /// </summary>
        private bool generateShortcut;

        /// <summary>
        /// 快捷方式列表
        /// </summary>
        private List<string> shortcutList;

        /// <summary>
        /// 是否添加开机启动项
        /// </summary>
        private bool addBootOption;

        /// <summary>
        /// 是否安装完成后打开
        /// </summary>
        private bool openAfterSetup;

        /// <summary>
        /// 默认安装路径
        /// </summary>
        private string installPath;

        /// <summary>
        /// 待打包文件夹
        /// </summary>
        private string packedDir;

        /// <summary>
        /// 待打包文件夹大小
        /// </summary>
        private long packedDirSize;

        /// <summary>
        /// 主程序文件
        /// </summary>
        private string mainEXE;

        /// <summary>
        /// 安装完成运行的命令
        /// </summary>
        private string runAfterSetup;

        /// <summary>
        /// 是否生成卸载程序
        /// </summary>
        private bool generateUninstall;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string License
        {
            get
            {
                return license;
            }

            set
            {
                license = value;
            }
        }

        public bool GenerateShortcut
        {
            get
            {
                return generateShortcut;
            }

            set
            {
                generateShortcut = value;
            }
        }

        public bool AddBootOption
        {
            get
            {
                return addBootOption;
            }

            set
            {
                addBootOption = value;
            }
        }

        public bool OpenAfterSetup
        {
            get
            {
                return openAfterSetup;
            }

            set
            {
                openAfterSetup = value;
            }
        }

        public string InstallPath
        {
            get
            {
                return installPath;
            }

            set
            {
                installPath = value;
            }
        }

        public string PackedDir
        {
            get
            {
                return packedDir;
            }

            set
            {
                packedDir = value;
            }
        }

        public string MainEXE
        {
            get
            {
                return mainEXE;
            }

            set
            {
                mainEXE = value;
            }
        }

        public string RunAfterSetup
        {
            get
            {
                return runAfterSetup;
            }

            set
            {
                runAfterSetup = value;
            }
        }

        public bool GenerateUninstall
        {
            get
            {
                return generateUninstall;
            }

            set
            {
                generateUninstall = value;
            }
        }

        public List<string> ShortcutList
        {
            get
            {
                return shortcutList;
            }

            set
            {
                shortcutList = value;
            }
        }

        public long PackedDirSize
        {
            get
            {
                return packedDirSize;
            }

            set
            {
                packedDirSize = value;
            }
        }
    }
}