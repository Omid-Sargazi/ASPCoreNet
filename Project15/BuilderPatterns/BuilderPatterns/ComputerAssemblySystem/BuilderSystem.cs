using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatterns.ComputerAssemblySystem
{
    public class BuilderSystem
    {
        private readonly AssemblySystem _assemblySystem = new AssemblySystem();

        public BuilderSystem setProcessor(string processor)
        {
            _assemblySystem.Processor = processor;
            return this;
        }

        public BuilderSystem setRAM(string ram)
        {
            _assemblySystem.RAM = ram;
            return this;
        }

        public BuilderSystem setStorage(string storage)
        {
            _assemblySystem.Storage = storage;
            return this;
        }

        public BuilderSystem setGraphic()
        {
            _assemblySystem.Graphic = true;
            return this;
        }

        public BuilderSystem setOS()
        {
            _assemblySystem.OS = true;
            return this;
        }

        public AssemblySystem assemblySystem()
        {
            return _assemblySystem;
        }
    }
}