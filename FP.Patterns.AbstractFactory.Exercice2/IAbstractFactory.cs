namespace FP.Patterns.AbstractFactory.Exercice2
{
    public interface IAbstractFactory
    {
        ISport CreateSportVehicle();
        IUtilitary CreateUtilitaryVehicle();
        IElectric CreateElectricVehicle();
    }
}
