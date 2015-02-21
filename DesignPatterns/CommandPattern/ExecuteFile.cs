using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class ExecuteFile : Execute
    {
        public ExecuteFile()
        {
            Command = "File";
        }

        public override void ExecuteCommand()
        {
            Console.WriteLine("File command");
        }
    }
}
