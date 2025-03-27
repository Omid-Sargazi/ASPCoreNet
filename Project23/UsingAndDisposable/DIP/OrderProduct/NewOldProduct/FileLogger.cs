using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.OrderProduct.NewOldProduct
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", $"{DateTime.Now}: {message}\n");
        }
    }
}