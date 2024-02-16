using BuisnessLogicLeather.Models;

namespace BuisnessLogicLeather.CostCalculation
{
    public interface ICostCalculationLogic
    {
        public void UpdateCostCalculation(CostCalculationModel costModel);
        public decimal ResultCost(CostCalculationModel costModel, decimal pricePerManHour);
    }
}
