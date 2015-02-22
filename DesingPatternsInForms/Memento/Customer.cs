using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternsInForms.Memento
{
    internal class Customer
    {
        private string _name = string.Empty;
        private string _code = string.Empty;
        private string _address = string.Empty;
        private CustomerMemento _memento;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public Customer()
        {
            _name = "Shiv";
            _code = "Cust001";
            _address = "Mumbai";

            _memento = new CustomerMemento(_name, _code, _address);
        }

        public void Revert()
        {
            _name = _memento.Name;
            _code = _memento.Code;
            _address = _memento.Address;
        }
    }
}
