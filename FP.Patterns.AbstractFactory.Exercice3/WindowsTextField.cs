namespace FP.Patterns.AbstractFactory.Exercice3
{
    public class WindowsTextField : ITextField
    {
        public void Alert()
        {
            Console.WriteLine("This text field is for Windows");
        }
    }
}
