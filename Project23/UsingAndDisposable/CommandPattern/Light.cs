using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.CommandPattern
{
    public class Light
    {
        public void TurnOn() => Console.WriteLine("لامپ روشن شد");
        public void TurnOff() => Console.WriteLine("لامپ خاموش شد");
    }
}