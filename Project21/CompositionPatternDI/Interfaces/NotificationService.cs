using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.Interfaces
{
    public class NotificationService : INotification
    {
        public void Notify(string message, NotificationType type)
        {
            switch(type)
            {

            case NotificationType.SMS:
                SendSMSNotification(message);
                break;
            case NotificationType.Email:
                SendEmailNotification(message);
                break;
            case NotificationType.Push:
                SendPushNotification(message);
                break;
            default:
                throw new ArgumentException("INvalid Notification Type");
            }

        }

        private void SendEmailNotification(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }

        private void SendSMSNotification(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");

        }

        private void SendPushNotification(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}