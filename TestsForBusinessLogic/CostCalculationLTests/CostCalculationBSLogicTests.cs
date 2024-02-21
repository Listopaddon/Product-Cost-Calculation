using BuisnessLogicLeather.CostCalculation;
using BuisnessLogicLeather.LeatherProduct;
using BuisnessLogicLeather.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestsForBusinessLogic.CostCalculationLTests.SubObjects;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestsForBusinessLogic.CostCalculationTests
{
    [TestClass]
    public class CostCalculationBSLogicTests
    {
        CostCalculationLogic costCalculation;
        LeatherProductLogic leatherProduct;
        SubDataService<LeatherProductModel> subDS = new SubDataService<LeatherProductModel>();

        [TestInitialize]
        public void Initialize()
        {
            costCalculation = new CostCalculationLogic(subDS);
            leatherProduct = new LeatherProductLogic(subDS);

            List<LeatherProductModel> leatherProducts = new List<LeatherProductModel>()
            {
               new LeatherProductModel("Бизон", TypeProduct.Wallet, "Крэйзи хорс", "25x35", "Черный",new CostCalculationModel(10,25,0,12,30), "лфоылвфы"),
               new LeatherProductModel("Бизон2", TypeProduct.Wallet, "Крэйзи хорс", "25x35", "Коричневый",new CostCalculationModel(10,25,0,12,30), "ыфвыфв")
            };

            subDS.SaveData(leatherProducts);
        }

        [TestMethod]
        public void UpdateCostCalculation()
        {
            //Arrange
            List<LeatherProductModel> leathers = subDS.LoadData();
            CostCalculationModel expected = new CostCalculationModel(20, 30, 10, 20, 40);

            //Act
            costCalculation.UpdateCostCalculation(leathers[1].IdProduct, expected);

            //Assert
            List<LeatherProductModel> leathersResult = subDS.LoadData();

            Assert.AreEqual(leathersResult[1].CostProduct.CostOfAccessories, leathers[1].CostProduct.CostOfAccessories);
            Assert.AreEqual(leathersResult[1].CostProduct.DiscountPercentage, leathers[1].CostProduct.DiscountPercentage);
            Assert.AreEqual(leathersResult[1].CostProduct.PricePerSquarMeter, leathers[1].CostProduct.PricePerSquarMeter);
            Assert.AreEqual(leathersResult[1].CostProduct.SkinArea, leathers[1].CostProduct.SkinArea);
            Assert.AreEqual(leathersResult[1].CostProduct.TimeSpentOnProduction, leathers[1].CostProduct.TimeSpentOnProduction);
        }
    }
}
