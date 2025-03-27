using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP
{
    public class Notification
    {
        private readonly IMessageSender _messageSender;
        public Notification(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void Notify(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
}