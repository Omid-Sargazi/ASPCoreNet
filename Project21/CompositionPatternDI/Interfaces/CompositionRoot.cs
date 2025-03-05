using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.Interfaces
{
    public class CompositionRoot
    {
        public static INotification CreateNotificationService()
        {
            return new NotificationService();
        }
    }
}