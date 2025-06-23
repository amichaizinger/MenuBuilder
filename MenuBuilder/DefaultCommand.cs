using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public class DefaultCommand : IMenuCommand
    {
        public void Execute()
        {
            Console.WriteLine("This is a default command. No action defined.");
        }
    }
}
