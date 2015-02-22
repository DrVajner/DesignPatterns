using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class Address : ICustomerElements
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }

        public List<Phone> Phones { get; private set; }

        public Address()
        {
            Phones = new List<Phone>();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);

            foreach (var phone in Phones)
            {
                phone.Accept(visitor);
            }
        }
    }
}
