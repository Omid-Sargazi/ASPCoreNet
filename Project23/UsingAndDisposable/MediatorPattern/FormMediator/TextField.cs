using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.FormMediator
{
    public class TextField
    {
        private IFormMediator _mediator;
        private string _font;
        public void SetMediator(IFormMediator mediator)
        {
            _mediator = mediator;
        }
        public void SetFont(string font)
        {
            _font = font;
            Console.WriteLine($"TextField: فونت به {_font} تغییر کرد.");
        }

    }
}