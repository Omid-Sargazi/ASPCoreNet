using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.PrototypePatternDemo
{
    public class Style
    {
        public int BorderWidth {get; set;}
        public string BorderColor {get; set;}

        public Style(int borderWidth, string borderColor)
        {
            BorderWidth = borderWidth;
            BorderColor = borderColor;
        }

        public Style DeepCopy()
        {
            return new Style(this.BorderWidth, this.BorderColor);
        }

        public override string ToString()
        {
            return $"Border Width: {BorderWidth}, Border Color: {BorderColor}";
        }
    }
}