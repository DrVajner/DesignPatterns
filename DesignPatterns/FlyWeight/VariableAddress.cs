using System;

namespace DesignPatterns.FlyWeight
{
    class VariableAddress
    {
        public StaticAddress Address { get { return StaticAddressHolder.Address; } }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format(@"{0}{1}{2}", Name, Environment.NewLine, Address);
        }
    }
}
