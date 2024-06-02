namespace FP.Patterns.AbstractFactory.Exercice4
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
        ILabel CreateLabel();
    }
}
