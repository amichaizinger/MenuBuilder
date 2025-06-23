using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
            var commandList = new List<string>(Commands.Keys);
            bool showMenu = true;

            while (showMenu)
            {
                int currentOption = 1;

                Console.WriteLine("Choose an option:");
                foreach(var command in Commands)
                {
                    Console.WriteLine($"{currentOption}) {command.Key}");
                    currentOption++;
                }
                Console.WriteLine($"{currentOption}) Exit");
                Console.WriteLine("Select an option: ");

                string choice = Console.ReadLine();

                if(int.TryParse(choice, out int option) && option >0 && option <= Commands.Count+1)
                {
                    if (option == currentOption)
                    {
                        showMenu = false;
                        continue;
                    }

                    string selectedCommand = commandList[option - 1];
                    IMenuCommand menuCommand = Commands[selectedCommand];
                    menuCommand.Execute();
                }
                else
                {
                    Console.WriteLine("Invalid option. try again.");
                    continue;
                }

               
            }
        }
    }
}
