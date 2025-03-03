using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingwithRedis.Interfaces
{
    public class FileGreeter : IGreeter
    {
        private string _filePath;
        public FileGreeter(string filePath)
        {
            _filePath = filePath;
        }
        public void Greet(string message)
        {
            Console.WriteLine($"Writing to {_filePath}: {message}");
        }
    }
}