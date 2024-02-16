using BuisnessLogicLeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLeather.LeatherProduct
{
    public interface ILeatherProductModel
    {
        public void AddLeatherProduct(string nameProduct, TypeProduct typeProduct, string skinType,
                                      string sizeProduct, string colorProduct, string descriptionProduct);
        public void UpdateLeatherProduct(LeatherProductModel leatherProduct);
        public void DeleteLeatherProduct(Guid guidModel);
        public List<LeatherProductModel> GetLeatherProducts();
        public LeatherProductModel GetLeatherProduct(Guid guidModel);

        public List<LeatherProductModel> GetAllProductByType(TypeProduct typeProduct);
    }
}
