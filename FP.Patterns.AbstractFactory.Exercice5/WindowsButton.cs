namespace FP.Patterns.AbstractFactory.Exercice5
{
    public class WindowsButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("This is a Windows Button");
        }
    }
}
