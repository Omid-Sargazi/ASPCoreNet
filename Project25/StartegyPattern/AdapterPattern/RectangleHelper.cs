namespace StartegyPattern.AdapterPattern
{
    public class RectangleHelper
    {
        public void Draw()
        {
            var rect = new LegacyRectangle();
            rect.Render();
        }
    }
}