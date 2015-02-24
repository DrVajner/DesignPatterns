using System;

namespace DesignPatterns.Bridge
{
    public class Bulb : IEquipment
    {
        public void Start()
        {
            Console.WriteLine("Warm up the bulb");
            Console.WriteLine("Glow the bulb");
        }

        public void Stop()
        {
            Console.WriteLine("Switch off the bulb");
        }
    }
}
