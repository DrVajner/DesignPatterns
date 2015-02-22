using System;

namespace DesignPatterns.Observer
{
    public class SMSNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("SMS notification code executed!");
        }
    }
}
