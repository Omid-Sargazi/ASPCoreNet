using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstarctFactoryPattern.interfaces
{
    public interface IUIFactory
    {
        public IButton CreateButton();
        public ICheckbox CreateCheckBox();
    }
}