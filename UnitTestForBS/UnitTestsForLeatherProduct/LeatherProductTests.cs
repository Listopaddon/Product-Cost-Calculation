using BuisnessLogicLeather.LeatherProduct;
using BuisnessLogicLeather.Models;
using System.Reflection;
using System;
using UnitTestForBS.SubObjects;

namespace UnitTestForBS.UnitTestsForLeatherProduct
{
    [TestClass]
    public class LeatherProductTests
    {
        LeatherProductLogic productLogic;
        SubDataService<LeatherProductModel> subDS = new SubDataService<LeatherProductModel>();


        [TestInitialize]
        public void Initialize()
        {
            productLogic = new LeatherProductLogic(subDS);
        }

        [TestMethod]
        public void AddLeatherProduct()
        {
            //Arrange
            LeatherProductModel expected = new LeatherProductModel(Guid.NewGuid(), "Бизон", TypeProduct.Wallet, "Крэйзи хорс",
                                                                   "25x35", "Черный", new CostCalculationModel(10, 25, 0, 12, 30),
                                                                   "Тест на добавление");

            //Act
            productLogic.AddLeatherProduct(expected.NameProduct, expected.TypeProduct, expected.SkinType, expected.SizeProduct,
                                           expected.ColorProduct, expected.DescriptionProduct);

            //Assert
            List<LeatherProductModel> results = subDS.LoadData();
            LeatherProductModel result = results[results.Count - 1];

            Assert.AreEqual(expected.NameProduct, result.NameProduct);
            Assert.AreEqual(expected.TypeProduct, result.TypeProduct);
            Assert.AreEqual(expected.SkinType, result.SkinType);
            Assert.AreEqual(expected.SizeProduct, result.SizeProduct);
            Assert.AreEqual(expected.ColorProduct, result.ColorProduct);
            Assert.AreEqual(expected.DescriptionProduct, result.DescriptionProduct);

        }

        [TestMethod]
        public void UpdateLeatherProduct()
        {
            //Arrange
            LeatherProductModel expected = new LeatherProductModel(Guid.NewGuid(), "Бизон", TypeProduct.Wallet, "Крэйзи хорс",
                                                                   "25x35", "Черный", new CostCalculationModel(10, (decimal)1.6, 0, 12, 30),
                                                                   "Тест на обновление");
            //productLogic.AddLeatherProduct("Ягуар", TypeProduct.Backpack, "Крэйзи хорс",
            //                                "235x353", "Черный", "Добавление в обновлениие");

            //Act
            List<LeatherProductModel> models = subDS.LoadData();
            List<LeatherProductModel> models2 = subDS.LoadData();
            Random random = new Random();
            Guid idModel = models[random.Next(0, models.Count - 1)].IdProduct;
            productLogic.UpdateLeatherProduct(idModel, expected);

            //Assert
            List<LeatherProductModel> resultModels = subDS.LoadData();
            LeatherProductModel result = productLogic.GetLeatherProduct(idModel);

            Assert.AreEqual(expected.NameProduct, result.NameProduct);
            Assert.AreEqual(expected.TypeProduct, result.TypeProduct);
            Assert.AreEqual(expected.SkinType, result.SkinType);
            Assert.AreEqual(expected.SizeProduct, result.SizeProduct);
            Assert.AreEqual(expected.ColorProduct, result.ColorProduct);
            Assert.AreEqual(expected.DescriptionProduct, result.DescriptionProduct);

        }

        [TestMethod]
        public void DeleteLeatherProduct()
        {
            //Arrange
            LeatherProductModel expected = null;
            productLogic.AddLeatherProduct("Леопард", TypeProduct.LadyBag, "Крэйзи хорс",
                                            "55x33", "Черный", "Добавление в удалении");

            //Act
            List<LeatherProductModel> models = subDS.LoadData();
            Random random = new Random();
            Guid idModel = models[random.Next(0, models.Count - 1)].IdProduct;
            productLogic.DeleteLeatherProduct(idModel);

            //Assert
            List<LeatherProductModel> modelsResult = subDS.LoadData();
            LeatherProductModel result = productLogic.GetLeatherProduct(idModel);

            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void GetLeatherProducts()
        {
            //Arrange
            List<LeatherProductModel> expected = subDS.LoadData();
            productLogic.AddLeatherProduct("Леопард", TypeProduct.LadyBag, "Крэйзи хорс",
                                            "55x33", "Черный", "Добавление в изьятии");

            //Act
            List<LeatherProductModel> result = subDS.LoadData();

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].NameProduct, result[i].NameProduct);
                Assert.AreEqual(expected[i].TypeProduct, result[i].TypeProduct);
                Assert.AreEqual(expected[i].SkinType, result[i].SkinType);
                Assert.AreEqual(expected[i].SizeProduct, result[i].SizeProduct);
                Assert.AreEqual(expected[i].ColorProduct, result[i].ColorProduct);
                Assert.AreEqual(expected[i].DescriptionProduct, result[i].DescriptionProduct);
            }
        }

        [TestMethod]
        public void GetLeatherProduct()
        {
            //Arrange
            LeatherProductModel expected = new LeatherProductModel(Guid.NewGuid(), "Леопард", TypeProduct.LadyBag, "Крэйзи хорс",
                                            "55x33", "Черный", new CostCalculationModel(0, 0, 0, 0, 0), "Добавление в изьятии");
            productLogic.AddLeatherProduct("Леопард", TypeProduct.LadyBag, "Крэйзи хорс",
                                            "55x33", "Черный", "Добавление в изьятии");

            //Act
            List<LeatherProductModel> resultModels = subDS.LoadData();
            Guid idModel = resultModels[resultModels.Count - 1].IdProduct;
            LeatherProductModel result = productLogic.GetLeatherProduct(idModel);

            //Assert
            Assert.AreEqual(expected.NameProduct, result.NameProduct);
            Assert.AreEqual(expected.TypeProduct, result.TypeProduct);
            Assert.AreEqual(expected.SkinType, result.SkinType);
            Assert.AreEqual(expected.SizeProduct, result.SizeProduct);
            Assert.AreEqual(expected.ColorProduct, result.ColorProduct);
            Assert.AreEqual(expected.DescriptionProduct, result.DescriptionProduct);
        }

        [TestMethod]
        public void GetAllProductByType()
        {
            //Arrange
            List<LeatherProductModel> expected = productLogic.GetAllProductByType(TypeProduct.LadyBag);

            //Act
            List<LeatherProductModel> result = productLogic.GetAllProductByType(TypeProduct.LadyBag);

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].NameProduct, result[i].NameProduct);
                Assert.AreEqual(expected[i].TypeProduct, result[i].TypeProduct);
                Assert.AreEqual(expected[i].SkinType, result[i].SkinType);
                Assert.AreEqual(expected[i].SizeProduct, result[i].SizeProduct);
                Assert.AreEqual(expected[i].ColorProduct, result[i].ColorProduct);
                Assert.AreEqual(expected[i].DescriptionProduct, result[i].DescriptionProduct);
            }
        }
    }
}
