using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PrototypePattern.DeepCopy
{
    public class Address
    {
        public string Street { get; set; }

        public Address()
        {
            Street = string.Empty;
        }

        public Address GetClone()
        {
            return (Address)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("Address:{0}", Street);
        }
    }
}
