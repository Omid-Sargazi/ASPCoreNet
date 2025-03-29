using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.FormMediator
{
    public interface IFormMediator
    {
        void Notify(string sender, string eventName, string data = null);
    }
}