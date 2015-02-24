using System;

namespace DesignPatterns.Bridge
{
    public class Refrigerator : IEquipment
    {
        public void Start()
        {
            Console.WriteLine("Start Compressor");
            Console.WriteLine("Start Ice Cooling");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Ice Cooling");
            Console.WriteLine("Stop Compressor");
        }
    }
}
