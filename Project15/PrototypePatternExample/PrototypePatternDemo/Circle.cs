using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.PrototypePatternDemo
{
    public class Circle : Shape
    {
        public int Radius {get; set;}
        public(int X, int Y) Position {get; set;}

        public Circle(string color, int radius, (int x, int y) position, Style style)
        {
            Color = color;
            Radius = radius;
            Position = position;
            ShapeStyle = style;
        }
        public override Shape DeepCopy()
        {
            Circle copy = (Circle)this.MemberwiseClone();
            copy.ShapeStyle = this.ShapeStyle?.DeepCopy();
            return copy;
        }

        public override Shape ShallowCopy()
        {
            return (Circle)this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Circle -> Color: {Color}, Radius: {Radius}, Position: ({Position.X}, {Position.Y}), Style: {ShapeStyle}";
        }
    }
}