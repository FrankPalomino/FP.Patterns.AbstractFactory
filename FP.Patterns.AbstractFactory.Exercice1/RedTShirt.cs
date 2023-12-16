using FP.Patterns.AbstractFactory.Exercice1;

namespace FP.Patterns.AbstractFactory
{
    internal class RedTShirt : ITShirtProduct
    {
        public string GetInfo()
        {
            return "Red T-Shirt";
        }
    }
}
