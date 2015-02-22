using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var customer = new Customer { Name = "Customer1" };

            var address = new Address { Address1 = "Address 1 Line 1", Address2 = "Address 1 Line 2" };
            address.Phones.Add(new Phone { Number = "0123443210" });
            customer.Addresses.Add(address);

            address = new Address { Address1 = "Address 2 Line 1", Address2 = "Address 2 Line 2" };
            address.Phones.Add(new Phone { Number = "0011223344" });
            address.Phones.Add(new Phone { Number = "99887766" });

            customer.Addresses.Add(address);



            var stringVisitor = new StringVisitor();
            customer.Accept(stringVisitor);
            Console.WriteLine(stringVisitor.Data);

            var xmlVisitor = new XmlVisitor();
            customer.Accept(xmlVisitor);
            Console.WriteLine(xmlVisitor.Data);
        }
    }
}
