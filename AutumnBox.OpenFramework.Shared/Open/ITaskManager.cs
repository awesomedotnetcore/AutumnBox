﻿using AutumnBox.OpenFramework.Extension;
using AutumnBox.OpenFramework.Management.ExtTask;
using System;

namespace AutumnBox.OpenFramework.Open
{
    /// <summary>
    /// 运行管理器
    /// </summary>
    public interface ITaskManager
    {
        /// <summary>
        /// 获取所有运行中的拓展模块线程
        /// </summary>
        /// <returns></returns>
        IExtensionTask[] Tasks { get; }
        /// <summary>
        /// 获取一个新的,未开始的拓展模块线程
        /// </summary>
        /// <param name="extensionClassName"></param>
        /// <exception cref="ArgumentException">当目标拓展未被找到时抛出</exception>
        /// <returns></returns>
        IExtensionTask CreateNewTaskOf(string extensionClassName);
        /// <summary>
        /// 获取一个新的,未开始的拓展模块线程
        /// </summary>
        /// <returns></returns>
        IExtensionTask CreateNewTaskOf<T>() where T : IExtension;
        /// <summary>
        /// 获取一个新的,未开始的拓展模块线程
        /// </summary>
        /// <param name="t"></param>
        /// <exception cref="ArgumentException">当传入的类型非拓展模块时抛出</exception>
        /// <returns></returns>
        IExtensionTask CreateNewTaskOf(Type t);
    }
}
