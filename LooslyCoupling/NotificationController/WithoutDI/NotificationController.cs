using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.NotificationController.WithoutDI
{
    public class NotificationController
    {
        public void SendNotification(string message)
        {
            bool useSMS = true;
            if(useSMS)
            {
                var notifier = new SmsNotifier("twilio-api-key");
                notifier.Notify(message);
            }
            else
            {
                var notifier = new PushNotifier("push-api-key");
                notifier.Notify(message);
            }
        }
    }
}