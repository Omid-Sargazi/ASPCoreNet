using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.ProxyPattern.VideoProblem
{
    public class RealVideo : IVideo
    {
        private string _fileName;

        public RealVideo(string fileName)
        {
            _fileName = fileName;
        }

        private void Load()
        {
            Console.WriteLine($"ویدیو {_fileName} در حال بارگذاری است...");
            Thread.Sleep(2000);
        }
        public void Play()
        {
            Console.WriteLine($"ویدیو {_fileName} در حال پخش است.");
        }
    }
}