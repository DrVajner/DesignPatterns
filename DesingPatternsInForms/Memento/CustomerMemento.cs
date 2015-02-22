using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesingPatternsInForms.Memento
{
    class CustomerMemento
    {
        public CustomerMemento(string name, string code, string address)
        {
            Name = name;
            Code = code;
            Address = address;
        }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Address { get; set; }
    }
}
