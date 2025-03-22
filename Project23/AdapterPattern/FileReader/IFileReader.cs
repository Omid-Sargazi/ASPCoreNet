using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern.FileReader
{
    public interface IFileReader
    {
        public string ReadFile();
    }
}