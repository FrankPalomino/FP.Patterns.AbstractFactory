namespace FP.Patterns.AbstractFactory.Exercice1
{
    internal class RedProductFactory : IProductFactory
    {
        public ISmartphoneProduct CreateElectronicProduct()
        {
            return new RedSmartPhone();
        }

        public ITShirtProduct CreateClothingProduct()
        {
            return new RedTShirt();
        }
    }
}
