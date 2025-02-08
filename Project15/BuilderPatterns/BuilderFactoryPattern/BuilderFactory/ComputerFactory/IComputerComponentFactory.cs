using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderFactory.ComputerFactory
{
    public interface IComputerComponentFactory
    {
        string CreateCPU();
        string CreateRAM();
        string CreateGPU();
        string CreateStorage();
    }
}