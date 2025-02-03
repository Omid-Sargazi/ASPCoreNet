using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealImage : IImage
    {
        private string _filename;
        public RealImage(string fileName)
        {
            _filename = fileName;
            LoadImageFromDisk();
            
        }
        public void Display()
        {
           
            Console.WriteLine($"Displaying image: {_filename}");
        }

        private void LoadImageFromDisk()
        {
            Console.WriteLine($"Loading image from disk: {_filename}...");
            System.Threading.Thread.Sleep(2000);
        }
    }
}