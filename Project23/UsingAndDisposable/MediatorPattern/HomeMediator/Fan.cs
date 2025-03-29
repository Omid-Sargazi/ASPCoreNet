using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.HomeMediator
{
    public class Fan
    {
        private IHomeMediator _mediator;
        private bool _isOn;
        public void SetMediator(IHomeMediator mediator) => _mediator = mediator;
        public void TurnOn()
        {
            _isOn = true;
        }

        public void TurnOff()
        {
            _isOn = false;
        }
    }
}