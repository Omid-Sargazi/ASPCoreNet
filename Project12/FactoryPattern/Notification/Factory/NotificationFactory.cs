using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Notification.Interfaces;

namespace FactoryPattern.Notification.Factory
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();

        public void Notify(string message)
        {
           INotification notification = CreateNotification();
           notification.Show(message);
        }
    }
}