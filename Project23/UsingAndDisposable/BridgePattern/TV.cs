using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern
{
    public class TV : IDevice
    {
        public void TurnOff()
        {
            Console.WriteLine("TV is turned OFF");
        }

        public void TurnOn()
        {
            Console.WriteLine("TV is turned ON");
        }
    }
}