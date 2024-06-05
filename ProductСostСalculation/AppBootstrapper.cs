using Caliburn.Micro;
using System.Windows;

namespace ProductСostСalculation
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<LeatherProductMainViewModel>();
        }
    }
}
