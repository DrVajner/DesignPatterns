using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class Customer : ICustomerElements
    {
        public string Name { get; set; }

        public List<Address> Addresses { get; private set; }

        public Customer()
        {
            Addresses = new List<Address>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach (var address in Addresses)
            {
                address.Accept(visitor);
            }
        }
    }
}
