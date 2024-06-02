namespace FP.Patterns.AbstractFactory.Exercice4
{
    public class LightThemeFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ILabel CreateLabel()
        {
            return new LightLabel();
        }

        public ITextBox CreateTextBox()
        {
            return new LightTextBox();
        }
    }
}
