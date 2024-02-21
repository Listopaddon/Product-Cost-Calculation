using BuisnessLogicLeather.Models;
using DataService;

namespace BuisnessLogicLeather.LeatherProduct
{
    public class LeatherProductLogic : ILeatherProductModel
    {
        IDS<LeatherProductModel> dataService;

        public LeatherProductLogic(IDS<LeatherProductModel> dataService)
        {
            this.dataService = dataService;
        }

        public void AddLeatherProduct(string nameProduct, TypeProduct typeProduct, string skinType,
                                      string sizeProduct, string colorProduct, string descriptionProduct)
        {
            List<LeatherProductModel> leatherProducts = dataService.LoadData();
            CostCalculationModel costCalculation = new CostCalculationModel(0, 0, 0, 0, 0);
            LeatherProductModel newProduct = new LeatherProductModel(nameProduct, typeProduct, skinType,
                                                                     sizeProduct, colorProduct, costCalculation, descriptionProduct);

            leatherProducts.Add(newProduct);
            dataService.SaveData(leatherProducts);
        }

        public void DeleteLeatherProduct(Guid guidModel)
        {
            List<LeatherProductModel> leatherProducts = dataService.LoadData();

            for (int i = 0; i < leatherProducts.Count; i++)
            {
                if (leatherProducts[i].IdProduct == guidModel)
                {
                    leatherProducts.Remove(leatherProducts[i]);
                    break;
                }
            }

            dataService.SaveData(leatherProducts);
        }

        public List<LeatherProductModel> GetAllProductByType(TypeProduct typeProduct)
        {
            List<LeatherProductModel> leatherProducts = dataService.LoadData();
            List<LeatherProductModel> resultProducts = new List<LeatherProductModel>();

            for (int i = 0; i < leatherProducts.Count; i++)
            {
                if (leatherProducts[i].TypeProduct == typeProduct)
                {
                    resultProducts.Add(leatherProducts[i]);
                }
            }

            return resultProducts;
        }

        public LeatherProductModel GetLeatherProduct(Guid guidModel)
        {
            List<LeatherProductModel> leatherProducts = dataService.LoadData();

            for (int i = 0; i < leatherProducts.Count; i++)
            {
                if (leatherProducts[i].IdProduct == guidModel)
                {
                    return leatherProducts[i];
                }
            }

            return null;
        }

        public List<LeatherProductModel> GetLeatherProducts()
        {
            return dataService.LoadData();
        }

        public void UpdateLeatherProduct(LeatherProductModel leatherProduct)
        {
            List<LeatherProductModel> leatherProducts = dataService.LoadData();

            for (int i = 0; i < leatherProducts.Count; i++)
            {
                if (leatherProducts[i].IdProduct == leatherProduct.IdProduct)
                {
                    leatherProducts[i] = leatherProduct;
                }
            }
        }
    }
}
