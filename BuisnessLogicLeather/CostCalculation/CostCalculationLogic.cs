using BuisnessLogicLeather.Models;
using DataService;
using System.Runtime.ConstrainedExecution;

namespace BuisnessLogicLeather.CostCalculation
{
    public class CostCalculationLogic : ICostCalculationLogic
    {
        DS<LeatherProductModel> dateService = new DS<LeatherProductModel>();
        public void UpdateCostCalculation(CostCalculationModel costModel)
        {
            List<LeatherProductModel> productModels = dateService.LoadData();
            for (int i = 0; i < productModels.Count; i++)
            {
                if (productModels[i].CostProduct.IdCost == costModel.IdCost)
                {
                    productModels[i].CostProduct.PricePerSquarMeter = costModel.PricePerSquarMeter;
                    productModels[i].CostProduct.SkinArea = costModel.SkinArea;
                    productModels[i].CostProduct.TimeSpentOnProduction = costModel.TimeSpentOnProduction;
                    productModels[i].CostProduct.CostOfAccessories = costModel.CostOfAccessories;
                    productModels[i].CostProduct.DiscountPercentage = costModel.DiscountPercentage;
                    break;
                }
            }

            dateService.SaveData(productModels);
        }

        public decimal ResultCost(CostCalculationModel costModel, decimal pricePerManHour)
        {
            decimal resultTime = costModel.TimeSpentOnProduction * pricePerManHour;
            decimal resultPricePerSkin = costModel.SkinArea * costModel.PricePerSquarMeter;
            decimal resultPrice = (resultTime + resultPricePerSkin + costModel.CostOfAccessories) / costModel.DiscountPercentage;

            return resultPrice;
        }
    }
}
