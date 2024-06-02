namespace FP.Patterns.AbstractFactory.Exercice4
{
    public class DarkThemeFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new DarkButton();
        }

        public ILabel CreateLabel()
        {
            return new DarkLabel();
        }

        public ITextBox CreateTextBox()
        {
            return new DarkTextBox();
        }
    }
}
