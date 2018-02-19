﻿/********************************************************************************
** auth： zsh2401@163.com
** date： 2018/1/12 23:45:40
** filename: BuildPropKeys.cs
** compiler: Visual Studio 2017
** desc： ...
*********************************************************************************/
namespace AutumnBox.Basic.Device
{
    public static class BuildPropKeys
    {
        public const string Board = "ro.product.board";
        public const string ProductName = "ro.product.name";
        public const string Model = "ro.product.model";
        public const string Brand = "ro.product.brand";
        public const string SdkVersion = "ro.build.version.sdk";
        public const string AndroidVersion = "ro.build.version.release";
        public const string NavigationBar = "qemu.hw.mainkeys";
    }
}