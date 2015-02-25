using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.ChainOfResponsibility;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = new Client();
            client.DoSomething();

            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
