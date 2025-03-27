using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.DeliveryProblem
{
    public interface IDeliveryLogger
    {
        public void Log(string message);
    }
}