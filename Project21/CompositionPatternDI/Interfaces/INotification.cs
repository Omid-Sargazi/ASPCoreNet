using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositionPatternDI.Interfaces
{
    public interface INotification
    {
        public void Notify(string message, NotificationType type);
    }

    public enum NotificationType
    {
        Email,
        SMS,
        Push,
    }
}