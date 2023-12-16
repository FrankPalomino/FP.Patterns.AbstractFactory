namespace FP.Patterns.AbstractFactory.Exercice1
{
    internal class BlueProductFactory : IProductFactory
    {
        public ISmartphoneProduct CreateElectronicProduct()
        {
            return new BlueSmartPhone();
        }

        public ITShirtProduct CreateClothingProduct()
        {
            return new BlueTShirt();
        }
    }
}
