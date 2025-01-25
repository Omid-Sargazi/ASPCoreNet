using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern.Notification.Interfaces
{
    public class SMSNotification : INotification
    {
        public void Show(string messsage)
        {
            Console.WriteLine("This is an SMS notification: " + messsage);
        }
    }
}