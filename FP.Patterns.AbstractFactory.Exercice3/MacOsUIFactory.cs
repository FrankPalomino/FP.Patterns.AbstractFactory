namespace FP.Patterns.AbstractFactory.Exercice3
{
    public class MacOsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }

        public ITextField CreateTextField()
        {
            return new MacOSTextField();
        }
    }
}
