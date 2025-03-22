using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.ImageViewer
{
    public class BmpViewer
    {
        public void ShowBmp(string bmpImage)
        {
            Console.WriteLine($"Displaying BMP image: {bmpImage}");
        }
    }
}