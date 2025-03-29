using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.HomeMediator
{
    public interface IHomeMediator
    {
        void Notify(string sender, string eventName);
    }
}