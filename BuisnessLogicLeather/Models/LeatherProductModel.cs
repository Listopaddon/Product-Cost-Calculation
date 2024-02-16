namespace BuisnessLogicLeather.Models
{
    public class LeatherProductModel
    {
        private Guid idProduct;
        private string nameProduct;
        private TypeProduct typeProduct;
        private string skinType;
        private string sizeProduct;
        private string colorProduct;
        private CostCalculationModel costProduct;
        private string descriptionProduct;

        public LeatherProductModel(string nameProduct, TypeProduct typeProduct, string skinType,
                                   string sizeProduct, string colorProduct,CostCalculationModel costProduct, string descriptionProduct)
        {
            this.idProduct = Guid.NewGuid();
            this.nameProduct = nameProduct;
            this.typeProduct = typeProduct;
            this.skinType = skinType;
            this.sizeProduct = sizeProduct;
            this.colorProduct = colorProduct;
            this.costProduct = costProduct;
            this.descriptionProduct = descriptionProduct;
        }

        public Guid IdProduct { get { return idProduct; } }
        public string NameProduct { get { return nameProduct; } }
        public TypeProduct TypeProduct { get { return typeProduct; } }
        public string SkinType { get { return skinType; } }
        public string Sizeproduct { get { return sizeProduct; } }
        public string Colorproduct { get { return colorProduct; } }
        public CostCalculationModel CostProduct { get { return costProduct; } set { costProduct = value; } }
        public string DescriptionProduct { get { return descriptionProduct; } }
    }
}
