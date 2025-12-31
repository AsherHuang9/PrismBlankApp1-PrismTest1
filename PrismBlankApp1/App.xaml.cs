using System.Windows;
using Prism.Ioc;
using PrismBlankApp1.ViewModels;
using PrismBlankApp1.Views;
using System.Runtime.Versioning; // 添加此行以使用 SupportedOSPlatform 特性

namespace PrismBlankApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        /// <summary>
        /// 注册区域
        /// </summary>
        /// <param name="containerRegistry"></param>
        [SupportedOSPlatform("windows7.0")] // 添加此特性以消除 CA1416 警告
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<IndexView, IndexViewModel>("IndexView");
            containerRegistry.RegisterForNavigation<ToDoView,TodoViewModel>("ToDoView");
            containerRegistry.RegisterForNavigation<MemoView,MemoViewmodel>("MemoView");
            containerRegistry.RegisterForNavigation<SettingsView,SettingsViewModel>("SettingsView");
           
        }
    }
}
