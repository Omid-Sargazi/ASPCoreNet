using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactory.Interfaces;

namespace AbstarctFactory.Factories
{
    public class WndowsFactoryLogger : ILogger
    {
        public IDatabaseLogger CreateDatabaseLogger()
        {
           return new WindowsDatabaseLogger();
        }

        public IFileLogger CreateFileLogger()
        {
           return new WindowsFileLogger();
        }
    }
}