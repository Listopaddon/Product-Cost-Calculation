using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductСostСalculation.ViewModels.CostCalculationViewModel
{
    public class CostCalculationViewModel
    {
        private decimal skinArea;
        private decimal pricePerSquarMeter;
        private decimal discountPercentage;
        private decimal timeSpentOnProduction;
        private decimal costOfAccessories;

        public CostCalculationViewModel(decimal skinArea, decimal pricePerSquarMeter, decimal discountPercentage,
                                    decimal timeSpentOnProduction, decimal costOfAccessories)
        {
            this.skinArea = skinArea;
            this.pricePerSquarMeter = pricePerSquarMeter;
            this.discountPercentage = discountPercentage;
            this.timeSpentOnProduction = timeSpentOnProduction;
            this.costOfAccessories = costOfAccessories;
        }

        public decimal SkinArea { get { return skinArea; } set { skinArea = value; } }
        public decimal PricePerSquarMeter { get { return pricePerSquarMeter; } set { pricePerSquarMeter = value; } }
        public decimal DiscountPercentage { get { return discountPercentage; } set { discountPercentage = value; } }
        public decimal TimeSpentOnProduction { get { return timeSpentOnProduction; } set { timeSpentOnProduction = value; } }
        public decimal CostOfAccessories { get { return costOfAccessories; } set { costOfAccessories = value; } }
    }
}
