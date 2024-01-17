namespace FP.Patterns.AbstractFactory.Exercice3
{
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }

        public ITextField CreateTextField()
        {
            return new WindowsTextField();
        }
    }
}
