using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.CrossPlatformUILibrary
{
    public class Application
    {
        private readonly IButton _button;
        private readonly ITextBox _textBox;
        private readonly IDropdown _dropdown;

        public Application(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _textBox = factory.CreateTextBox();
            _dropdown = factory.CreateDropdown();
        }

        public void RenderUI()
        {
            _button.render();
            _dropdown.render();
            _textBox.render();
        }
    }
}