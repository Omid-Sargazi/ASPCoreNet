using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LooslyCoupling.CrossPlatformUILibrary
{
    public class MacButton : IButton
    {
        public void render()
        {
            Console.WriteLine("Rendering a macOS-style Button");
        }
    }
}