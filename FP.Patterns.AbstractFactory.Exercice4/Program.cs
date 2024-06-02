using FP.Patterns.AbstractFactory.Exercice4;

Console.WriteLine("Select theme: \n1 - Light Theme.\n2 - Dark Theme.");

string theme = Console.ReadLine();

if (!string.IsNullOrEmpty(theme))
{
    IUIFactory factory = default(IUIFactory);
    switch (theme)
    {
        case "1":
            factory = new LightThemeFactory();
            break;
        case "2":
            factory = new DarkThemeFactory();
            break;
    }

    var button = factory.CreateButton();
    var textBox = factory.CreateTextBox();
    var label = factory.CreateLabel();

    button.Click();
    textBox.Text();
    label.LabelText();
}