using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.ShallowCopy
{
    public class Address
    {
        public string Street { get; set; }

        public Address()
        {
            Street = string.Empty;
        }

        public override string ToString()
        {
            return string.Format("Address:{0}", Street);
        }
    }
}
