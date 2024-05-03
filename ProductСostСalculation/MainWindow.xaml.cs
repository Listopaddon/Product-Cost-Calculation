using BuisnessLogicLeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UnitTestForBS.SubObjects;

namespace ProductСostСalculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SubDataService<LeatherProductModel> subData = new SubDataService<LeatherProductModel>();
            LeatherProductModel model = new LeatherProductModel(Guid.NewGuid(), "gfdsgds", TypeProduct.Backpack, "adsada",
                                                                 "fsafdsf", "asdasd", new CostCalculationModel(0, 0, 0, 0, 0), "sadasdas");
            List<LeatherProductModel> Lists = new List<LeatherProductModel>();
            Lists.Add(model);
            subData.SaveData(Lists);
            List<LeatherProductModel> leathers = subData.LoadData();

            ProductsGrid.ItemsSource = leathers;
        }
    }
}
