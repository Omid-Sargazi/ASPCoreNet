using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstarctFactory.Interfaces
{
    public interface ILogger
    {
        public IFileLogger CreateFileLogger();
        public IDatabaseLogger CreateDatabaseLogger();
    }
}