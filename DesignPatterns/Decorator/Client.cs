using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            Console.WriteLine("Order 1");
            IOrder order = new OrderBread();
            Console.WriteLine(order.Prepare());
            Console.WriteLine(order.CalculateCost().ToString());
            Console.WriteLine();

            Console.WriteLine("Order 2");
            order = new OrderDrinks(new OrderChicken(new OrderBread()));
            Console.WriteLine(order.Prepare());
            Console.WriteLine(order.CalculateCost().ToString());
        }
    }
}
