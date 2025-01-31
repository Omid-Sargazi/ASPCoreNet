using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependanyInjection.Repositories;

namespace DependanyInjection.Implements
{
    public class LocalStorageService : IStorageService
    {
        private readonly string _storagePath;

        public LocalStorageService(string storagePath)
        {
            _storagePath = storagePath;
        }
        public byte[] GetFile(string fileName)
        {
            var filePath = Path.Combine(_storagePath, fileName);
            return File.ReadAllBytes(filePath);
        }

        public void SaveFile(string fileName, byte[] content)
        {
            var filePath = Path.Combine(_storagePath, fileName);
            File.WriteAllBytes(filePath, content);
        }
    }
}