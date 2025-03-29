using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.FormMediator
{
    public class FormMediator : IFormMediator
    {
        private ListBox _listBox;
        private TextField _textField;
        private Button _button;

        public FormMediator(ListBox listBox, TextField textField, Button button)
        {
            _button = button;
            _listBox = listBox;
            _textField = textField;
        }
        public void Notify(string sender, string eventName, string data = null)
        {
            if(sender == "ListBox" && eventName == "SelectionChanged")
            {
                _textField.SetFont(data);
            }
            else if(sender == "Button" && eventName == "Click")
            {
               string selectedFont = _listBox.GetSelectedFont();
                Console.WriteLine($"فونت انتخاب‌شده: {selectedFont}");
            }
        }
    }
}