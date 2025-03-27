using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP.OrderProduct.NewOldProduct
{
    public interface ILogger
    {
        public void Log(string message);
    }
}