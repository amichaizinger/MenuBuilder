// See https://aka.ms/new-console-template for more information
using MenuBuilder;

int currentOption = 1;
Console.WriteLine("welcome to MenuBuilder");

IMenu mainMenu = new MainMenu();

while (true)
{
    Console.WriteLine("enter an option for the menu or finish by sending 0");
    string input = Console.ReadLine();

    if (input == "0")
    {
        break;
    }

    IMenuCommand menuCommand = new DefaultCommand();

    mainMenu.Commands.Add($"{currentOption}) {input}", menuCommand);
    currentOption++;
}

mainMenu.showMenu();

