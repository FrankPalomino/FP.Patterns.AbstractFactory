namespace FP.Patterns.AbstractFactory.Exercice2
{
    public class MotoFactory : IAbstractFactory
    {
        public IElectric CreateElectricVehicle()
        {
            return new ElectricMoto();
        }

        public ISport CreateSportVehicle()
        {
            return new SportMoto();
        }

        public IUtilitary CreateUtilitaryVehicle()
        {
            return new UtilitaryMoto();
        }
    }
}
