using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.BridgePattern
{
    public class BasicRemote : RemoteControl
    {
        public BasicRemote(IDevice device) : base(device)
        {
        }

        public override void TurnOff()
        {
            _device.TurnOff();
        }

        public override void TurnOn()
        {
            _device.TurnOn();
        }
    }
}