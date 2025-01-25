using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FactoryPattern.Notification.Interfaces
{
    public interface INotification
    {
        public void Show(string messsage);
    }
}