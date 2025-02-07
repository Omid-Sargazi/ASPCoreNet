using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.Implements;
using AbstarctFactoryPattern.interfaces;

namespace AbstarctFactoryPattern.Factory
{
    public class WinFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new WinCheck();
        }
    }
}