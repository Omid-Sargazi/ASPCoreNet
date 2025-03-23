using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable
{
    public class FileManager : IDisposable
    {
        private StreamWriter _writer;
        private bool _disposed = false;
        public FileManager(string filePath)
        {
            _writer = new StreamWriter(filePath);
            Console.WriteLine($"فایل {filePath} باز شد.");
        }

        public void Write(string text)
        {
            if(!_disposed)
            {
                _writer.WriteLine(text);
            }
            else
            {
                throw new ObjectDisposedException("FileManager", "نمی‌تونید بعد از Dispose چیزی بنویسید!");
            }
        }

        
        public void Dispose()
        {
           if(!_disposed)
           {
            _writer.Dispose();
            _disposed = true;
            Console.WriteLine("done");
           }
        }
    }
}