using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.Implements;
using AbstarctFactoryPattern.interfaces;

namespace AbstarctFactoryPattern.Factory
{
    public class MacOSFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new MacCheck();
        }
    }
}