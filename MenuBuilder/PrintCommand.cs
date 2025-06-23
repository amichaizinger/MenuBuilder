using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class PrintCommand : IMenuCommand
    {
        private readonly string _message;
        public PrintCommand(string message)
        {
            _message = message;
        }

        public void printMessage()
        {
            Console.WriteLine(_message);
        }
        public void Execute()
        {
            printMessage();
        }

    }
}
