using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.BetterSolution
{
    class Client : IClient
    {
        #region IClient Members

        public void DoSomething()
        {
            var logger = new FileLogger();
            var customer = new CustomerDecoration(logger);
            customer.Add();
        }

        #endregion
    }
}
