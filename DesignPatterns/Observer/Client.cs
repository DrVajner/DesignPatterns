using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Client : IClient
    {
        public void DoSomething()
        {
            var customerCode = string.Empty;

            var notifier = new Notifier();
            notifier.AddNotification(new EmailNotification());
            notifier.AddNotification(new EventLogNotification());

            Console.WriteLine("Enter customer code:");
            customerCode = Console.ReadLine();

            if (customerCode.Length > 10)
            {
                notifier.NotifyAll();
            }
        }
    }
}
