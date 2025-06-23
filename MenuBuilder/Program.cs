// See https://aka.ms/new-console-template for more information
using System.Windows.Input;
using MenuBuilder;

Console.WriteLine("welcome to MenuBuilder");
Console.WriteLine("do you want the user to chose by the number or by the name of the option. enter name or number");
string inputMethod = Console.ReadLine()?.ToLower();

IMenuInputHandler inputHandler;

switch(inputMethod)
{
    case "number":
        inputHandler = new NumberInputHandler();
        break;
    case "name":
        inputHandler = new NameInputHandler();
        break;
    default:
        Console.WriteLine("Invalid input method. Defaulting to number input.");
        inputHandler = new NumberInputHandler();
        break;
}

IMenu mainMenu = new MainMenu(inputHandler);


mainMenu.Commands.Add("print the apps default message", new PrintCommand("Hello from Main!"));
mainMenu.Commands.Add("print whatever you want", new InputPrintCommand());
mainMenu.Commands.Add("use our default command", new DefaultCommand());


mainMenu.showMenu();

