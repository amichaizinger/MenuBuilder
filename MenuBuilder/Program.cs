// See https://aka.ms/new-console-template for more information
using MenuBuilder;

Console.WriteLine("welcome to MenuBuilder");

IMenu mainMenu = new MainMenu();


mainMenu.Commands.Add("option1", new DefaultCommand());
mainMenu.Commands.Add("option2", new DefaultCommand());
mainMenu.Commands.Add("option3", new DefaultCommand());


mainMenu.showMenu();

