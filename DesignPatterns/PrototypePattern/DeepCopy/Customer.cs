using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.DeepCopy
{
    public class Customer
    {
        public string CustomerCode { get; set; } // This is copied
        public string CustomerName { get; set; } // This is copied
        public Address Address { get; set; } // This is cloned

        public Customer()
        {
            CustomerCode = string.Empty;
            CustomerName = string.Empty;
            Address = new Address();
        }

        public Customer GetClone()
        {
            var customer = (Customer)MemberwiseClone();
            customer.Address = (Address)Address.GetClone();
            return customer;
        }

        public override string ToString()
        {
            return string.Format(@"Code:{0} Name:{1} {2}", CustomerCode, CustomerName, Address);
        }
    }
}
