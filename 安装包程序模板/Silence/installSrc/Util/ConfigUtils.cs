using InstallPack.Model;
using System;

namespace InstallPack.Util
{
    class ConfigUtils
    {
        /// <summary>
        /// 临时文件位置
        /// </summary>
        public static readonly string WORK_PLACE = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\swskins_" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

        /// <summary>
        /// 全局配置参数
        /// </summary>
        public static Configure GlobalConfigure;
    }
}