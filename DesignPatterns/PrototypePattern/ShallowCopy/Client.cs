using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.ShallowCopy
{
    class Client : IClient
    {

        #region IClient Members

        public void DoSomething()
        {
            var customer1 = new Customer();

            customer1.CustomerCode = "001";
            customer1.CustomerName = "OldCustomer";
            customer1.Address.Street = "Address1";

            var customer2 = customer1.GetClone();
            customer2.CustomerCode = "002";
            customer2.CustomerName = "NewCustomer";
            customer2.Address.Street = "Address2";

            Console.WriteLine(string.Format(@"Customer 1:{0}", customer1));
            Console.WriteLine(string.Format(@"Customer 2:{0}", customer2));
        }

        #endregion
    }
}
