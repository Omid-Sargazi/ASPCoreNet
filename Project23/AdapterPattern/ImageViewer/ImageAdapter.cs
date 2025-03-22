using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.ImageViewer
{
    public class ImageAdapter : IImageViewer
    {
        private readonly BmpViewer _bmpViewer;
        public ImageAdapter(BmpViewer bmpViewer)
        {
            _bmpViewer = bmpViewer;
        }
        public void DisplayImage(string image)
        {
            Console.WriteLine($"Converting PNG to BMP: {image}");
            _bmpViewer.ShowBmp(image);
        }
    }
}