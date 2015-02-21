using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class Client : IClient
    {
        #region IClient Members

        public void DoSomething()
        {
            var invoker = new Invoker();

            var command = invoker.GetCommand("exit");
            command.ExecuteCommand();

            command = invoker.GetCommand("open");
            command.ExecuteCommand();

            command = invoker.GetCommand("file");
            command.ExecuteCommand();

            command = invoker.GetCommand("print");
            command.ExecuteCommand();
        }

        #endregion
    }
}
