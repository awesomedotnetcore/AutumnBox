﻿/*

* ==============================================================================
*
* Filename: ILeafPanelManager
* Description: 
*
* Version: 1.0
* Created: 2020/3/14 0:58:59
* Compiler: Visual Studio 2019
*
* Author: zsh2401
*
* ==============================================================================
*/

namespace AutumnBox.OpenFramework.Open
{
    /// <summary>
    /// LeafPanel
    /// </summary>
    public interface IXCard
    {
        /// <summary>
        /// 优先级
        /// </summary>
        int Priority { get; }
        /// <summary>
        /// 界面
        /// </summary>
        object View { get; }
        /// <summary>
        /// 创建
        /// </summary>
        void Create();
        /// <summary>
        /// 更新内容
        /// </summary>
        void Update();
        /// <summary>
        /// 摧毁
        /// </summary>
        void Destory();
    }
    /// <summary>
    /// Leaf面板管理器
    /// </summary>
    public interface IXCardsManager
    {
        /// <summary>
        /// 注册一个LeafPanel
        /// </summary>
        /// <param name="card"></param>
        void Register(IXCard card);
        /// <summary>
        /// 取消注册一个LeafPanel
        /// </summary>
        /// <param name="card"></param>
        void Unregister(IXCard card);
    }
}
