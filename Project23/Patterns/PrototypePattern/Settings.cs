using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class Settings : IPrototype<Settings>
    {
        public string Theme {get; set;}
        public int FontSize {get; set;}
        public Settings CLone()
        {
            return (Settings)this.MemberwiseClone();
        }
    }
}