using System;

namespace DesignPatterns.Observer
{
    public class EventLogNotification : INotification
    {
        public void Notify()
        {
            Console.WriteLine("Event Log notification code executed!");
        }
    }
}
