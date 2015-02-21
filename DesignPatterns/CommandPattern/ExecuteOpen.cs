using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class ExecuteOpen : Execute
    {
        public ExecuteOpen()
        {
            Command = "Open";
        }

        public override void ExecuteCommand()
        {
            Console.WriteLine("Open command");
        }
    }
}
