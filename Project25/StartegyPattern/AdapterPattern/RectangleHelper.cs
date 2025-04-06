namespace StartegyPattern.AdapterPattern
{
    public class RectangleHelper : IShape
    {
        private LegacyRectangle _rectangle;
        public RectangleHelper(LegacyRectangle retangle)
        {
            _rectangle = retangle;
        }
        public void Draw()
        {
           _rectangle.Render();
        }
    }
}