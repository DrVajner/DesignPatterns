using System;

namespace DesignPatterns.FlyWeight
{
    class StaticAddress
    {
        public string Address { get; private set; }
        public string Street { get; private set; }
        public string Pin { get; private set; }
        public string Country { get; private set; }

        public StaticAddress()
        {
            Address = "Vasant Oscar";
            Street = "Mulund";
            Pin = "81";
            Country = "India";
        }

        public override string ToString()
        {
            return string.Format(@"Address - {0}{1}Street - {2}{1}Pin - {3}{1}Country - {4}", Address, Environment.NewLine, Street, Pin, Country);
        }
    }
}
