namespace FP.Patterns.AbstractFactory
{
    internal class IronFactory : Factory
    {
        public Table CreateTable() => new IronTable();
    }
}
