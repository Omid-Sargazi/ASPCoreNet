using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactoryPattern.interfaces;

namespace AbstarctFactoryPattern
{
    public class ClientUI
    {
        private IButton _button;
        private ICheckbox _checkbox;

        public ClientUI(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckBox();
        }


        public void RenderUI()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
}