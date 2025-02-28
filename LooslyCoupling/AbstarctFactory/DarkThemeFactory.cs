using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.AbstarctFactory
{
    public interface DarkThemeFactory
    {
        public DarkButton CreateButton();
        public DarkCheckbox CreateCheckbox();
        public DarkTextBox  CreateTextBox();
    }
}