using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern
{
    public interface IDevice
    {
        public void TurnOn();
        public void TurnOff();
    }
}