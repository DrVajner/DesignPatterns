using System;

namespace DesignPatterns.Facade
{
    class Product
    {
        public string GetDetails()
        {
            Console.WriteLine("Getting product information...");
            return "Product information";
        }
    }
}
