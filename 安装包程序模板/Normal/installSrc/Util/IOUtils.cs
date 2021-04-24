using Microsoft.Win32;
using Swsk33.ReadAndWriteSharp;
using System;
using System.IO;
using System.Reflection;

namespace InstallPack.Util
{
    class IOUtils
    {
        /// <summary>
        /// 创建快捷方式
        /// </summary>
        /// <param name="exePath">exe文件原位置</param>
        /// <param name="destPath">快捷方式目标位置</param>
        public static void CreateShortcut(string exePath, string destPath)
        {
            string workingDirectory = exePath.Substring(0, exePath.LastIndexOf("\\"));
            TerminalUtils.RunCommand(ConfigUtils.WORK_PLACE + "\\shortcut.exe", "\"" + exePath + "\" \"" + destPath + "\" \"" + workingDirectory + "\"");
        }

        /// <summary>
        /// 添加程序启动项
        /// </summary>
        /// <param name="name">启动项名称</param>
        /// <param name="path">启动项路径</param>
        public static void AddBootOption(string name, string path)
        {
            RegistryKey mainKey = Registry.LocalMachine;
            RegistryKey bootOptionKey = mainKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            bootOptionKey.SetValue(name, path, RegistryValueKind.String);
            bootOptionKey.Close();
        }

        /// <summary>
        /// 添加程序卸载信息
        /// </summary>
        /// <param name="name">程序名</param>
        /// <param name="installPath">安装目录</param>
        /// <param name="mainProgram">主程序名</param>
        /// <param name="uninstallProgram">卸载程序名</param>
        public static void AddUninstallInfo(string name, string installPath, string mainProgram, string uninstallProgram)
        {
            RegistryKey mainKey = Registry.LocalMachine;
            RegistryKey uninstallInfo = mainKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall", true);
            uninstallInfo.CreateSubKey(name);
            RegistryKey appInfo = mainKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\" + name, true);
            appInfo.SetValue("DisplayIcon", installPath + "\\" + mainProgram);
            appInfo.SetValue("DisplayName", name);
            appInfo.SetValue("InstallLocation", installPath);
            appInfo.SetValue("UninstallString", installPath + "\\" + uninstallProgram);
            uninstallInfo.Close();
            appInfo.Close();
        }

        /// <summary>
        /// 利用7z命令获取压缩文件解压后的大小
        /// </summary>
        /// <param name="filePath">压缩文件</param>
        /// <returns></returns>
        public static long Get7zOriginSize(string filePath)
        {
            string[] terminalResult = TerminalUtils.RunCommand("7z", "l \"" + filePath + "\"");
            string sizeInfo = terminalResult[0].Substring(terminalResult[0].LastIndexOf(":") + 3).Trim();
            sizeInfo = sizeInfo.Substring(0, sizeInfo.IndexOf(" "));
            return long.Parse(sizeInfo);
        }

        /// <summary>
        /// 释放内嵌资源至指定位置
        /// </summary>
        /// <param name="resource">嵌入的资源，此参数写作：命名空间.文件夹名.文件名.扩展名</param>
        /// <param name="path">释放到位置</param>
        /// <returns>是否释放成功</returns>
        public static bool ExtractFile(String resource, String path)
        {
            bool result = false;
            Assembly assembly = Assembly.GetExecutingAssembly();
            BufferedStream input = new BufferedStream(assembly.GetManifestResourceStream(resource));
            FileStream output = new FileStream(path, FileMode.Create);
            byte[] data = new byte[1024];
            int lengthEachRead;
            while ((lengthEachRead = input.Read(data, 0, data.Length)) > 0)
            {
                output.Write(data, 0, lengthEachRead);
            }
            output.Flush();
            output.Close();
            if (File.Exists(path))
            {
                result = true;
            }
            return result;
        }
    }
}