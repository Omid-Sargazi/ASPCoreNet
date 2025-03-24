using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern
{
    public class Fan : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Fan is turned OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("Fan is turned ON");
        }
    }
}