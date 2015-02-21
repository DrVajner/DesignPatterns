using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public abstract class Execute
    {
        public string Command { get; set; }
        public virtual void ExecuteCommand() { }

        public Execute()
        {
            Command = string.Empty;
        }
    }
}
