using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public interface LightThemeFactory
    {
        public LightButton CreateButton();
        public LightCheckbox CreateCheckbox();
        public LightTextBox CreateTextBox();
    }
}