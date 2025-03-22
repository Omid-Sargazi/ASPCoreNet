using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.ImageViewer
{
    public interface IImageViewer
    {
        public void DisplayImage(string image);
    }
}