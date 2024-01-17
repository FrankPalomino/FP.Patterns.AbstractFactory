using FP.Patterns.AbstractFactory.Exercice3;

Console.WriteLine("1. Windows | 2. Mac OS");

var so = "-1";
while (!so.Equals("1") && !so.Equals("2")) 
{
    so = Console.ReadLine(); 
}

IUIFactory? factory = default;
switch (so)
{
    case "1":
        factory = new WindowsUIFactory();
        break;
    case "2":
        factory = new MacOsUIFactory();
        break;
    default:
        Console.WriteLine("Error matching");
        break;
}

IButton button = factory!.CreateButton();
ITextField textField = factory.CreateTextField();
ICheckbox checkbox = factory.CreateCheckbox();

button.TurnOn();
textField.Alert();
checkbox.Check();
