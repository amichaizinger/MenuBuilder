using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public interface IMenuInputHandler
    {
        public string getCommandKey(Dictionary<string, IMenuCommand> commands);
    }
}
