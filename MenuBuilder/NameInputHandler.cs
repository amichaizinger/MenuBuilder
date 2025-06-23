using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class NameInputHandler : IMenuInputHandler
    {
        public string getCommandKey(Dictionary<string, IMenuCommand> commands)
        {
            Console.WriteLine("Enter the name of the command you want to execute: ");
            string commandName = Console.ReadLine();

            if (commands.ContainsKey(commandName))
            {
                return commandName;
            }
            else if(commandName == "Exit")
            {
                return commandName;
            }
            else
            {
                return null;
            }
        }
    }
}
