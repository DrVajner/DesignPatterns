using System;

namespace DesignPatterns.Composite
{
    public class Phone : IBusinessObject
    {
        public void Update()
        {
            Console.WriteLine("Updating phones...");
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
