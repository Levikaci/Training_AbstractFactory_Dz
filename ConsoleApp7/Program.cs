using System;

public interface IGUIFactory
{
    Button CreateButton();
    Checkbox CreateCheckbox();
    RadioButton CreateRadioButton();
    TextBox CreateTextBox();
    Label CreateLabel();
}

public class Button { }
public class Checkbox { }
public class RadioButton { }
public class TextBox { }
public class Label { }

public class WinButton : Button { }
public class WinCheckbox : Checkbox { }
public class WinRadioButton : RadioButton { }
public class WinTextBox : TextBox { }
public class WinLabel : Label { }

public class MacButton : Button { }
public class MacCheckbox : Checkbox { }
public class MacRadioButton : RadioButton { }
public class MacTextBox : TextBox { }
public class MacLabel : Label { }

public class WinFactory : IGUIFactory
{
    public Button CreateButton()
    {
        Console.WriteLine("Создана кнопка для Win");
        return new WinButton();
    }

    public Checkbox CreateCheckbox()
    {
        Console.WriteLine("Создан чекбокс для Win");
        return new WinCheckbox();
    }

    public RadioButton CreateRadioButton()
    {
        Console.WriteLine("Создана радио-кнопка для Win");
        return new WinRadioButton();
    }

    public TextBox CreateTextBox()
    {
        Console.WriteLine("Создано текстовое поле для Win");
        return new WinTextBox();
    }

    public Label CreateLabel()
    {
        Console.WriteLine("Создана метка для Win");
        return new WinLabel();
    }
}


public class MacFactory : IGUIFactory
{
    public Button CreateButton()
    {
        Console.WriteLine("Создана кнопка для Mac");
        return new MacButton();
    }

    public Checkbox CreateCheckbox()
    {
        Console.WriteLine("Создан чекбокс для Mac");
        return new MacCheckbox();
    }

    public RadioButton CreateRadioButton()
    {
        Console.WriteLine("Создана радио-кнопка для Mac");
        return new MacRadioButton();
    }

    public TextBox CreateTextBox()
    {
        Console.WriteLine("Создано текстовое поле для Mac");
        return new MacTextBox();
    }

    public Label CreateLabel()
    {
        Console.WriteLine("Создана метка для Mac");
        return new MacLabel();
    }
}

class Program
{
    static void Main()
    {
        CreateUI(new WinFactory());
        CreateUI(new MacFactory());
    }

    static void CreateUI(IGUIFactory factory)
    {
        factory.CreateButton();
        factory.CreateCheckbox();
        factory.CreateRadioButton();
        factory.CreateTextBox();
        factory.CreateLabel();

        Console.WriteLine();
    }
}