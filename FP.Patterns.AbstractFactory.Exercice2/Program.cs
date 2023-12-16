using FP.Patterns.AbstractFactory.Exercice2;

Console.WriteLine("¿car or moto?");
IAbstractFactory factory = null;
var vehicleType = Console.ReadLine();

if (vehicleType is not null)
{
    switch (vehicleType)
    {
        case "car":
            factory = new CarFactory();
            break;
        case "moto":
            factory = new MotoFactory(); 
            break;
    }

    var utilitary = factory.CreateUtilitaryVehicle();
    utilitary.Show();
    var sport = factory.CreateSportVehicle();
    sport.Show();
    var electric = factory.CreateElectricVehicle();
    electric.Show();
}