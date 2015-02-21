using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SRP.Problem
{
    class Client : IClient
    {

        #region IClient Members

        public void DoSomething()
        {
            var customer = new Customer();
            customer.Add();
        }

        #endregion
    }
}
