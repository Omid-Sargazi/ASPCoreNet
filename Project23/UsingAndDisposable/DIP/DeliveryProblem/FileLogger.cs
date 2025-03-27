using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.DeliveryProblem
{
    public class FileLogger : IDeliveryLogger
    {
        public void Log(string message)
        {
             File.AppendAllText("delivery.log", $"{DateTime.Now}: {message}\n");
        }
    }
}