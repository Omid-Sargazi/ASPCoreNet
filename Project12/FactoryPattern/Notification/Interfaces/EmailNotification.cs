using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryPattern.Notification.Interfaces
{
    public class EmailNotification : INotification
    {
        public void Show(string messsage)
        {
            Console.WriteLine("This is an email notification: " + messsage);
        }
    }
}