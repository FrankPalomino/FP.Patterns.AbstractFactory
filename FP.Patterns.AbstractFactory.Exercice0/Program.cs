using FP.Patterns.AbstractFactory;

Factory factory = default;
Console.WriteLine("Iron or Wood products");

var products = Console.ReadLine();

switch (products)
{
    case "Iron":
        factory = new IronFactory();
        break;
    case "Wood":
        factory = new WoodFactory();
        break;
    default:
        Console.WriteLine("No products");
        break;
}

if (factory is null)
{
    return;
}

var table = factory.CreateTable();
Console.WriteLine(table.GetTable());
