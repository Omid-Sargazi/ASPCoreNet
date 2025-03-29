using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.FormMediator
{
    public class ListBox
    {
        private IFormMediator _mediator;
        private string _selectedFont;
        public void SetMediator(IFormMediator mediator)
        {
            _mediator = mediator;
        }
        public void SelectFont(string font)
        {
            _selectedFont = font;
            Console.WriteLine($"ListBox: فونت {font} انتخاب شد.");
            _mediator.Notify("ListBox", "SelectionChanged", font);
        }
        public string GetSelectedFont()=>_selectedFont;
    }
}