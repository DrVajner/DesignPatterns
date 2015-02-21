using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class ExecuteExit : Execute
    {
        public ExecuteExit()
        {
            Command = "Exit";
        }

        public override void ExecuteCommand()
        {
            Console.WriteLine("Exit command");
        }
    }
}
