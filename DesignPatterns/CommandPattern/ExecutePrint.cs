using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class ExecutePrint : Execute
    {
        public ExecutePrint()
        {
            Command = "Print";
        }

        public override void ExecuteCommand()
        {
            Console.WriteLine("Print command");
        }
    }
}
