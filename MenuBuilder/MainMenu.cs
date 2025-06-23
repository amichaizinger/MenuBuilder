using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class MainMenu : IMenu
    {
        public Dictionary<string, IMenuCommand> Commands { get; set; }

        public MainMenu()
        {
            Commands = new Dictionary<string, IMenuCommand>();
        }

        public void showMenu()
        {
            bool showMenu = true;
            int currentOption = 1;

            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                foreach(var command in Commands)
                {
                    Console.WriteLine($"{currentOption}) {command.Key}");
                    currentOption++;
                }
                Console.WriteLine($"{currentOption}) Exit");
                Console.WriteLine("Select an option: ");

                string choice = Console.ReadLine();

                if(int.TryParse(choice, out int option) && option >0 && option <= Commands.Count)
                {
                    if (option == currentOption)
                    {
                        showMenu = false;
                        continue;
                    }

                    IMenuCommand menuCommand = Commands[choice];
                    menuCommand.Execute();
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

               
            }
        }
    }
}
