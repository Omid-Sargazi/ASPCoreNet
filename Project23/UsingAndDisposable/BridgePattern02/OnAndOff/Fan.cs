using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern02.OnAndOff
{
    public class Fan : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("Fan is turned Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Fan is turned ON");
        }
    }
}