using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern
{
    public interface IChatRoom
    {
        void SendMessage(string message, User user);
    }
}