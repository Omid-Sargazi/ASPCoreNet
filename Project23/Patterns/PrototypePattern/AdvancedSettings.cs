using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.PrototypePattern
{
    public class AdvancedSettings : IPrototype<AdvancedSettings>
    {
        public string Theme {get; set;}
        public int FontSize {get; set;}
        public Dictionary<string,string> Preference {get; set;}
        public AdvancedSettings CLone()
        {
            var clone = (AdvancedSettings)this.MemberwiseClone();
            clone.Preference = new Dictionary<string, string>(this.Preference);
            return clone;
        }
    }
}