namespace FP.Patterns.AbstractFactory.Exercice1
{
    internal class Client
    {
        private readonly IProductFactory _productFactory;

        public Client(IProductFactory productFactory)
        {
            _productFactory = productFactory;
        }

        public string GetElectronicProductInfo()
        {
            return _productFactory.CreateElectronicProduct().GetInfo();
        }

        public string GetClothingProductInfo()
        {
            return _productFactory.CreateClothingProduct().GetInfo();
        }
    }
}
