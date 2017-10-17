/* =============================================================================*\
*
* Filename: App.xaml.cs
* Description: 
*
* Version: 1.0
* Created: 7/31/2017 05:34:44(UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using AutumnBox.Basic.Devices;
using AutumnBox.Basic.Executer;
using AutumnBox.Helper;
using AutumnBox.Util;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Navigation;

namespace AutumnBox
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        internal static StartWindow OwnerWindow { get { return (Current.MainWindow as StartWindow); } }
        internal static DeviceSimpleInfo SelectedDevice = new DeviceSimpleInfo() { Status = DeviceStatus.NO_DEVICE };
        internal static DevicesMonitor DevicesListener = new DevicesMonitor();//设备监听器
        protected override void OnStartup(StartupEventArgs e)
        {
            Logger.T(this, "OnStartup");
            SystemHelper.StartAutoGC();
            base.OnStartup(e);
        }
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            SystemHelper.AppExit();
        }
    }
}
