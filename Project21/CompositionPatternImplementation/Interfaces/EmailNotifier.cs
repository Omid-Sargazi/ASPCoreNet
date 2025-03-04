using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompositionPatternImplementation.Models;

namespace CompositionPatternImplementation.Interfaces
{
    public class EmailNotifier : INotifier
    {
        public void SendNotification(User user)
        {
            Console.WriteLine("Notifier is sent");
        }
    }
}