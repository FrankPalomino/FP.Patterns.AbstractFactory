namespace FP.Patterns.AbstractFactory.Exercice1
{
    internal interface IProductFactory
    {
        ISmartphoneProduct CreateElectronicProduct();
        ITShirtProduct CreateClothingProduct();
    }
}
