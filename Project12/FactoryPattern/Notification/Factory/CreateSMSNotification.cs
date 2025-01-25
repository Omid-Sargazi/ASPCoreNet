using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryPattern.Notification.Interfaces;

namespace FactoryPattern.Notification.Factory
{
    public class CreateSMSNotification : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}