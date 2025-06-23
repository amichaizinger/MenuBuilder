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

            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1)");
                Console.WriteLine("2)");
                Console.WriteLine("3) Exit");
                Console.WriteLine("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
