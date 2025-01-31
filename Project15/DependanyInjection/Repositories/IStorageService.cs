using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependanyInjection.Repositories
{
    public interface IStorageService
    {
        void SaveFile(string fileName, byte[] content);
        byte[] GetFile(string fileName);
    }
}