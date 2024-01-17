namespace FP.Patterns.AbstractFactory.Exercice3
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Check()
        {
            Console.WriteLine("Checked for Windows");
        }
    }
}
