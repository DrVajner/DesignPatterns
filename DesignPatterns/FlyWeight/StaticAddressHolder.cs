
namespace DesignPatterns.FlyWeight
{
    class StaticAddressHolder
    {
        private static StaticAddress _address = new StaticAddress();
        public static StaticAddress Address { get { return _address; } }
    }
}
