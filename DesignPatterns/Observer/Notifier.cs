using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Notifier
    {
        private List<INotification> _notificationList = new List<INotification>();

        public void AddNotification(INotification notification)
        {
            _notificationList.Add(notification);
        }

        public void RemoveNotification(INotification notification)
        {
            _notificationList.Remove(notification);
        }

        public void NotifyAll()
        {
            foreach (var notification in _notificationList)
            {
                notification.Notify();
            }
        }
    }
}
