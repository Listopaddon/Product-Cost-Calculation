using BuisnessLogicLeather.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductСostСalculation.Models.LeatherProductViewModel
{
    public class LeatherProductViewModel
    {
        private Guid idProduct;
        private string nameProduct;
        private TypeProduct typeProduct;
        private string skinType;
        private string sizeProduct;
        private string colorProduct;
        private CostCalculationModel costProduct;
        private string descriptionProduct;

        public LeatherProductViewModel(Guid idProduct, string nameProduct, TypeProduct typeProduct, string skinType,
                                   string sizeProduct, string colorProduct, CostCalculationModel costProduct, string descriptionProduct)
        {

            this.idProduct = idProduct;
            this.nameProduct = nameProduct;
            this.typeProduct = typeProduct;
            this.skinType = skinType;
            this.sizeProduct = sizeProduct;
            this.colorProduct = colorProduct;
            this.costProduct = costProduct;
            this.descriptionProduct = descriptionProduct;
        }

        public Guid IdProduct { get { return idProduct; } }
        public string NameProduct { get { return nameProduct; } set { nameProduct = value; } }
        public TypeProduct TypeProduct { get { return typeProduct; } set { typeProduct = value; } }
        public string SkinType { get { return skinType; } set { skinType = value; } }
        public string SizeProduct { get { return sizeProduct; } set { sizeProduct = value; } }
        public string ColorProduct { get { return colorProduct; } set { colorProduct = value; } }
        public CostCalculationModel CostProduct { get { return costProduct; } set { costProduct = value; } }
        public string DescriptionProduct { get { return descriptionProduct; } set { descriptionProduct = value; } }
    }
}
