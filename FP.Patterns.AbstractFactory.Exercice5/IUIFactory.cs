namespace FP.Patterns.AbstractFactory.Exercice5
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
