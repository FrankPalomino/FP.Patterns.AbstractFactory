namespace FP.Patterns.AbstractFactory.Exercice2
{
    public class CarFactory : IAbstractFactory
    {
        public ISport CreateSportVehicle()
        {
            return new SportCar();
        }

        public IUtilitary CreateUtilitaryVehicle()
        {
            return new UtilitaryCar();
        }

        public IElectric CreateElectricVehicle()
        {
            return new ElectricCar();
        }
    }
}
