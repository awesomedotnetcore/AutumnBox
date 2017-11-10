﻿/* =============================================================================*\
*
* Filename: FilePuller
* Description: 
*
* Version: 1.0
* Created: 2017/11/10 18:03:01 (UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;
using AutumnBox.Basic.Executer;
using AutumnBox.Basic.Function.Args;

namespace AutumnBox.Basic.Function.Modules
{
    public class FilePuller : FunctionModule
    {
        private FilePullArgs _Args;
        protected override void AnalyzeArgs(ModuleArgs args)
        {
            base.AnalyzeArgs(args);
            _Args = (FilePullArgs)args;
            if (_Args.PhoneFilePath == null) throw new NullReferenceException("please set FilePullArgs.PhoneFilePath!");
        }
        protected override OutputData MainMethod()
        {
            return Ae($"pull {_Args.PhoneFilePath} {_Args.LocalFilePath}");
        }
    }
}
