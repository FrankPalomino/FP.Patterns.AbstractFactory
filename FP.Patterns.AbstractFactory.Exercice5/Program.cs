using FP.Patterns.AbstractFactory.Exercice5;

Console.WriteLine("Select SO:\n1. Windows\n2. Mac");
var so = Console.ReadLine();

IUIFactory factory = default;
if (!string.IsNullOrEmpty(so))
{
    switch (so)
    {
        case "1":
            factory = new WindowsFactory(); break;
        case "2":
            factory = new MacFactory(); break;
    }
}

IButton button = factory.CreateButton();
ICheckbox checkbox = factory.CreateCheckbox();

button.Click();
checkbox.Check();


