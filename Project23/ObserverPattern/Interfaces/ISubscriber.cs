using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface ISubscriber
    {
        void Update(string videoTitle);
    }
}