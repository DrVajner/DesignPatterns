using System;

namespace DesignPatterns.FlyWeight
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var address1 = new VariableAddress();
            address1.Name = "Shiv";
            var address2 = new VariableAddress();
            address2.Name = "Raju";

            Console.WriteLine(address1);
            Console.WriteLine(address2);
        }
    }
}
