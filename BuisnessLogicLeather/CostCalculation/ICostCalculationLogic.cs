using BuisnessLogicLeather.Models;

namespace BuisnessLogicLeather.CostCalculation
{
    public interface ICostCalculationLogic
    {
        public void UpdateCostCalculation(Guid idLeatheProduct, CostCalculationModel costModel);
        public decimal ResultCost(CostCalculationModel costModel, decimal pricePerManHour);
    }
}
