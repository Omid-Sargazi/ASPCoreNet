namespace  StartegyPattern.CompositePattern
{
    public class ShapeGroup : IShape
    {
        private List<IShape> shapes = new List<IShape>();
        public void Add(IShape shape) => shapes.Add(shape);

        public void Draw()
        {
            foreach(var shape in shapes) shape.Draw();
        }
    }
}