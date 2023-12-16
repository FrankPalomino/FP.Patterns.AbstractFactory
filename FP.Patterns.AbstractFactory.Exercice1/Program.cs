using FP.Patterns.AbstractFactory.Exercice1;

IProductFactory blueFactory = new BlueProductFactory();
IProductFactory redFactory = new RedProductFactory();

Client client = new Client(blueFactory);
Console.WriteLine(client.GetElectronicProductInfo());
Console.WriteLine(client.GetClothingProductInfo());

client = new Client(redFactory);
Console.WriteLine(client.GetElectronicProductInfo());
Console.WriteLine(client.GetClothingProductInfo());