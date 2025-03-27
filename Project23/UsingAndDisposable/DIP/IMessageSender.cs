using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
}