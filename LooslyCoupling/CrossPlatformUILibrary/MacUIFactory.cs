using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.CrossPlatformUILibrary
{
    public class MacUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            throw new NotImplementedException();
        }

        public IDropdown CreateDropdown()
        {
            throw new NotImplementedException();
        }

        public ITextBox CreateTextBox()
        {
            throw new NotImplementedException();
        }
    }
}