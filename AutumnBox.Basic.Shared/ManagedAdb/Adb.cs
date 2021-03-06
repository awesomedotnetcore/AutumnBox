﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/9/9 18:02:46 (UTC +8:00)
** desc： ...
*************************************************/
using System;
using System.IO;

namespace AutumnBox.Basic.ManagedAdb
{
    /// <summary>
    /// AutumnBox.Basic中与ADB程序直接接触的管理层
    /// </summary>
    public static class Adb
    {
        /// <summary>
        /// 管理器
        /// </summary>
        public static IAdbManager Manager { get; private set; }

        /// <summary>
        /// ADB临时文件路径
        /// </summary>
        [Obsolete("do not use", true)]
        public static string AdbTmpPathOnDevice { get; } = "/data/local/tmp";

        /// <summary>
        /// 服务器
        /// </summary>
        public static IAdbServer Server => Manager.Server;

        /// <summary>
        /// ADB文件
        /// </summary>
        public static FileInfo AdbFile => Manager.AdbFile;

        /// <summary>
        /// ADB文件路径
        /// </summary>
        public static string AdbFilePath => Manager.AdbFile.FullName;

        /// <summary>
        /// Fastboot文件
        /// </summary>
        public static FileInfo FastbootFile => Manager.FastbootFile;

        /// <summary>
        /// Fastboot文件路径
        /// </summary>
        public static string FastbootFilePath => Manager.FastbootFile.FullName;

        /// <summary>
        /// ADB文件夹路径
        /// </summary>
        public static DirectoryInfo AdbToolsDir => Manager.ToolsDir;

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="adbManager"></param>
        public static void Load(IAdbManager adbManager)
        {
            Manager = adbManager;
        }
    }
}
