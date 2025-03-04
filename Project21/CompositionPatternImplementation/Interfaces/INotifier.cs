using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompositionPatternImplementation.Models;

namespace CompositionPatternImplementation.Interfaces
{
    public interface INotifier
    {
        void SendNotification(User user);
    }
}