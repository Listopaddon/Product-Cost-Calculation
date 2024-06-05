using Caliburn.Micro;
using ProductСostСalculation.ViewModels.LeatherProductViewModel;
using System.Collections.ObjectModel;

namespace ProductСostСalculation
{
    public class LeatherProductMainViewModel : PropertyChangedBase

    {
        private ObservableCollection<LeatherProductViewModel> leatherProducts;
        //ILeatherProductLogic leatherLogic;

        public ObservableCollection<LeatherProductViewModel> LeatherProducts
        {
            get { return leatherProducts; }

            set
            {
                leatherProducts = value;
                NotifyOfPropertyChange(() => leatherProducts);
            }
        }

        public LeatherProductMainViewModel()
        {
            LeatherProducts = new ObservableCollection<LeatherProductViewModel>();
        }
    }
}

