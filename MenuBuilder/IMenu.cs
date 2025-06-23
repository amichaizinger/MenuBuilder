using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBuilder
{
    public interface IMenu
    {
        public Dictionary<string, IMenuCommand> Commands { get; set; }
        public void showMenu();
    }
}
