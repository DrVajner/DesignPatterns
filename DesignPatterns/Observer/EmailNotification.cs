using System;

namespace DesignPatterns.Observer
{
    public class EmailNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("Email notification code executed!");
        }
    }
}
