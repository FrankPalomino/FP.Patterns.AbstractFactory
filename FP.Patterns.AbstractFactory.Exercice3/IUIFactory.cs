namespace FP.Patterns.AbstractFactory.Exercice3
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextField CreateTextField();
        ICheckbox CreateCheckbox();
    }
}
