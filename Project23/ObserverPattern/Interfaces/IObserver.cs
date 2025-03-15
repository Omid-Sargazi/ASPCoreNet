using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
       void Update(float temp, float humidity, float pressure); 
    }
}