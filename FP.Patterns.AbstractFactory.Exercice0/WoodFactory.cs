namespace FP.Patterns.AbstractFactory
{
    internal class WoodFactory : Factory
    {
        public Table CreateTable()
        {
            return new WoodTable();
        }
    }
}
