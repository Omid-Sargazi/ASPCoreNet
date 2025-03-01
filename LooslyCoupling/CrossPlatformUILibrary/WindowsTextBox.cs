using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.CrossPlatformUILibrary
{
    public class WindowsTextBox : ITextBox
    {
        public void render()
        {
            Console.WriteLine("Rendering a Windows-style TextBox");
        }
    }
}