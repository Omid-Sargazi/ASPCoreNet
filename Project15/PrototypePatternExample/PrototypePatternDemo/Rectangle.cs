using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.PrototypePatternDemo
{
    public class Rectangle : Shape
    {
        public int Width {get; set;}
        public int Height {get; set;}
        public (int X, int Y) Position {get; set;}

        public Rectangle(string color, int width, int height, (int x, int y) position, Style style)
        {
            Color = color;
            Width = width;
            Height = height;
            Position = position;
            ShapeStyle = style;
        }
        
        public override Shape DeepCopy()
        {
            Rectangle copy = (Rectangle)this.MemberwiseClone();
            copy.ShapeStyle = this.ShapeStyle?.DeepCopy();
            return copy;
        }

        public override Shape ShallowCopy()
        {
            return (Shape)this.MemberwiseClone();
        }

         public override string ToString()
        {
            return $"Rectangle -> Color: {Color}, Width: {Width}, Height: {Height}, Position: ({Position.X}, {Position.Y}), Style: {ShapeStyle}";
        }
    }
}