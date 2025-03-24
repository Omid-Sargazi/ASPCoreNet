using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern
{
    public abstract class RemoteControl
    {
        protected IDevice _device;
        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public abstract void TurnOn();

        public abstract void TurnOff();
    }
}