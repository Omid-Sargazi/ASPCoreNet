using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.CrossPlatformUILibrary
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
        IDropdown CreateDropdown();
    }
}