using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Customer : IBusinessObject
    {
        private List<Address> _addresses = new List<Address>();
        public IEnumerable<Address> ChildObject
        {
            get
            {
                return _addresses;
            }
        }

        public void Update()
        {
            Console.WriteLine("Updating customer...");
        }

        public bool IsValid()
        {
            return true;
        }

        public void Add(Address address)
        {
            _addresses.Add(address);
        }
    }
}
