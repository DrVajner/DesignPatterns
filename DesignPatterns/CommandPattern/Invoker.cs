using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class Invoker
    {
        private ArrayList _arrayList = new ArrayList();
        public Invoker()
        {
            _arrayList.Add(new ExecuteExit());
            _arrayList.Add(new ExecuteFile());
            _arrayList.Add(new ExecuteOpen());
            _arrayList.Add(new ExecutePrint());
        }
        public Execute GetCommand(string command)
        {
            foreach (var item in _arrayList)
            {
                var executeCommand = (Execute)item;
                if (executeCommand.Command.Equals(command, StringComparison.OrdinalIgnoreCase))
                {
                    return executeCommand;
                }
            }

            return null;
        }
    }
}
