using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class InputPrintCommand : IMenuCommand
    {
        public void Execute()
        {
            Console.WriteLine("Please enter a message to print:");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine($"You entered: {userInput}");
            }
            else
            {
                Console.WriteLine("No input provided.");
            }
        }
    }
}
