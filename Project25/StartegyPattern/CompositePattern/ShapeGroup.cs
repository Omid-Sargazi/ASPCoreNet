namespace  StartegyPattern.CompositePattern
{
    public class ShapeGroup 
    {
        private List<Circle> circles = new List<Circle>();

        public void Add(Circle circle) => circles.Add(circle);

        public void Draw()
        {
            foreach (var circle in circles)
                circle.Draw();
        }
    }
}