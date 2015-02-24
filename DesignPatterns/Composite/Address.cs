using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class Address : IBusinessObject
    {
        private List<Phone> _phones = new List<Phone>();
        public IEnumerable<Phone> ChildObjects
        {
            get
            {
                return _phones;
            }
        }

        public void Update()
        {
            Console.WriteLine("Updating addresses...");
        }

        public bool IsValid()
        {
            return true;
        }

        public void Add(Phone phone)
        {
            _phones.Add(phone);
        }
    }
}
