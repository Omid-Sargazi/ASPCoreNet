using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.PrototypePatternDemo
{
    public abstract class Shape
    {
        public string Color {get; set;}
        public Style ShapeStyle {get; set;}
        
        public abstract Shape ShallowCopy();
        public abstract Shape DeepCopy();

        public override string ToString()
        {
           return $"Color: {Color}, Style: {ShapeStyle}";
        }
    }
}