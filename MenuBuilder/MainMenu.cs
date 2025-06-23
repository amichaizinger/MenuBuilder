using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MenuBuilder
{
    public class MainMenu : IMenu
    {
        public Dictionary<string, IMenuCommand> Commands { get; set; }
        private readonly IMenuInputHandler _menuInputHandler;

        public MainMenu(IMenuInputHandler menuInputHandler)
        {
            Commands = new Dictionary<string, IMenuCommand>();
            _menuInputHandler = menuInputHandler ?? throw new ArgumentNullException(nameof(menuInputHandler));

        }



        public void showMenu()
        {
            bool showMenu = true;

            while (showMenu)
            {
                int currentOption = 1;

                Console.WriteLine("Choose an option:");
                foreach (var command in Commands)
                {
                    Console.WriteLine($"{currentOption}) {command.Key}");
                    currentOption++;
                }
                Console.WriteLine($"{currentOption}) Exit");

                string selectedCommand = _menuInputHandler.getCommandKey(Commands);

                if (selectedCommand == null)
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }
                else if (selectedCommand == "Exit")
                {
                    showMenu = false;
                    continue;
                }
                else if (Commands.TryGetValue(selectedCommand, out IMenuCommand commandToExecute))
                {
                    commandToExecute.Execute();
                }
                else
                {
                    Console.WriteLine("Command not found. Please try again.");
                }
            }



        }
    }
}
