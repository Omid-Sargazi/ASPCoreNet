using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyClass : IImage
    {
        private IImage _realImage;
        private readonly string _filename;

        public ProxyClass(string filename)
        {
            _filename = filename;
        }
        public void Display()
        {
            if(_realImage == null)
                _realImage = new RealImage(_filename);
            _realImage.Display();
        }
    }
}