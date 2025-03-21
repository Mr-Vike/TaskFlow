
using System.Windows;
using TaskFlow.ViewModels;
using TaskFlow.Services;
using Unity;

namespace TaskFlow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var container = new UnityContainer();

            container.RegisterType<INavigationService, NavigationService>();
            container.RegisterType<IDashboardViewModel, DashboardViewModel>();

            

        }
    }

}
