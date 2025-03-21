using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypeExamples.API.ImplementingIDisposable
{
    public class FileHandler : IDisposable
    {
        private FileStream _fileStream;
        private bool _disposed  = false;
        public FileHandler(string filePath)
        {
            _fileStream = new FileStream(filePath, FileMode.Open);
        }

        public void writeToFile(string text)
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("FileHandler");
            }
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(text);
            _fileStream.Write(buffer, 0, buffer.Length);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void  Dispose(bool disposing)
        {
            if(!_disposed)
            {
                if(disposing)
                {
                    if(_fileStream != null)
                    {
                        _fileStream.Close();
                        _fileStream.Dispose();
                    }
                }
                _disposed = true;
            }
        }
        ~FileHandler()
        {
            Dispose(false);
        }
    }
}