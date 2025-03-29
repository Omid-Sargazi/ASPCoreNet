using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.FormMediator
{
    public class Button
    {
        private  IFormMediator _mediator;
        public void SetMediator(IFormMediator mediator)
        {
            _mediator = mediator;
        }

        public void Click()
        {
            Console.WriteLine("Button: کلیک شد.");
            _mediator.Notify("Button", "Click");
        }
    }
}