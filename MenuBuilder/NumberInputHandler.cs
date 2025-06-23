using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class NumberInputHandler : IMenuInputHandler
    {
        public string getCommandKey(Dictionary<string, IMenuCommand> commands)
        {
            var commandList = new List<string>(commands.Keys);

            Console.WriteLine("Select the number you want: ");

            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int option) && option > 0 && option <= commandList.Count + 1)
            {
                if (option == commandList.Count + 1)
                {
                    return "Exit";
                }
                else
                {
                    return commandList[option - 1];
                }
            }

            else
            {
                return null;
            }


        }
    }
}