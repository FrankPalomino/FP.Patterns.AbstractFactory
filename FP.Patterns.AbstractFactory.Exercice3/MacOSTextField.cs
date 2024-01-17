namespace FP.Patterns.AbstractFactory.Exercice3
{
    public class MacOSTextField : ITextField
    {
        public void Alert()
        {
            Console.WriteLine("This text field is for Mac OS");
        }
    }
}
