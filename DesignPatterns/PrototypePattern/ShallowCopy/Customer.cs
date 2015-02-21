using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.ShallowCopy
{
    public class Customer
    {
        public string CustomerCode { get; set; } // This is copied
        public string CustomerName { get; set; } // This is copied
        public Address Address { get; set; } // Only reference is copied

        public Customer()
        {
            CustomerCode = string.Empty;
            CustomerName = string.Empty;
            Address = new Address();
        }

        public Customer GetClone()
        {
            return (Customer)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format(@"Code:{0} Name:{1} {2}", CustomerCode, CustomerName, Address);
        }
    }
}
