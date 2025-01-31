using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependanyInjection.Repositories;

namespace DependanyInjection.Implements
{
    public class CloudStorageService : IStorageService
    {
        private readonly string _cloudConnectionString;

        public CloudStorageService(string cloudConnectionString)
        {
            _cloudConnectionString = cloudConnectionString;
        }
        public byte[] GetFile(string fileName)
        {
             Console.WriteLine($"File '{fileName}' retrieved from cloud storage with connection string: {_cloudConnectionString}");
             return new byte[0];
        }

        public void SaveFile(string fileName, byte[] content)
        {
              Console.WriteLine($"File '{fileName}' saved to cloud storage with connection string: {_cloudConnectionString}");
        }
    }
}