using Caliburn.Micro;
using ProductСostСalculation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProductСostСalculation
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override async void OnStartup(object sender, StartupEventArgs e)
        {
           await DisplayRootViewForAsync(typeof(LeatherProductViewLogicModel));
        }
    }
}
