﻿using System;

namespace AutumnBox.OpenFramework.Extension.Leaf
{
    /// <summary>
    /// LeafUI Finish异常标记
    /// </summary>
    public class LeafTerminatedException : Exception
    {
        /// <summary>
        /// 构造LeafUI Finish异常标记
        /// </summary>
        /// <param name="exitCode"></param>
        public LeafTerminatedException(int exitCode)
        {
            ExitCode = exitCode;
        }
        /// <summary>
        /// 返回码
        /// </summary>
        public int ExitCode { get; }
    }
}
