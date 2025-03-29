using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.HomeMediator
{
    public class Light
    {
        private IHomeMediator _mediator;
        private bool _isOn;
        public void SetMediator(IHomeMediator mediator) => _mediator = mediator;
        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Light: لامپ روشن شد.");
        }
        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Light: لامپ خاموش شد.");
        }
    }
}