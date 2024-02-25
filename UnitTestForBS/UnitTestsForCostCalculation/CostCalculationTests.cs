using BuisnessLogicLeather.CostCalculation;
using BuisnessLogicLeather.Models;
using UnitTestForBS.SubObjects;

namespace UnitTestForBS.UnitTestsForCostCalculation
{
    public class CostCalculationTests
    {
        [TestClass]
        public class CostCalculationBSLogicTests
        {
            CostCalculationLogic costCalculation;
            SubDataService<LeatherProductModel> subDS = new SubDataService<LeatherProductModel>();

            [TestInitialize]
            public void Initialize()
            {
                costCalculation = new CostCalculationLogic(subDS);

                List<LeatherProductModel> leatherProducts = new List<LeatherProductModel>()
            {
               new LeatherProductModel(Guid.NewGuid(),"Бизон", TypeProduct.Wallet, "Крэйзи хорс", "25x35", "Черный",new CostCalculationModel(10,25,0,12,30), "лфоылвфы"),
               new LeatherProductModel(Guid.NewGuid(),"Бизон2", TypeProduct.Wallet, "Крэйзи хорс", "25x35", "Коричневый",new CostCalculationModel(10,25,0,12,30), "ыфвыфв")
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

                Assert.AreEqual(leathersResult[1].CostProduct.CostOfAccessories, expected.CostOfAccessories);
                Assert.AreEqual(leathersResult[1].CostProduct.DiscountPercentage, expected.DiscountPercentage);
                Assert.AreEqual(leathersResult[1].CostProduct.PricePerSquarMeter, expected.PricePerSquarMeter);
                Assert.AreEqual(leathersResult[1].CostProduct.SkinArea, expected.SkinArea);
                Assert.AreEqual(leathersResult[1].CostProduct.TimeSpentOnProduction, expected.TimeSpentOnProduction);
            }

            [TestMethod]
            public void ResultCost()
            {
                //Arrange 
                List<LeatherProductModel> leathers = subDS.LoadData();
                decimal expected = costCalculation.ResultCost(leathers[0].CostProduct, 4);

                //Act
                decimal result = costCalculation.ResultCost(leathers[0].CostProduct, 4);

                //Assert
                Assert.AreEqual(expected, result);
            }
        }
    }
}
