using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactory.Interfaces;

namespace AbstarctFactory.Factories
{
    public class MacFactoryLogger : ILogger
    {
        public IDatabaseLogger CreateDatabaseLogger()
        {
            return new MacDatabaseLogger();
        }

        public IFileLogger CreateFileLogger()
        {
            return new MacFileLogger();
        }
    }
}