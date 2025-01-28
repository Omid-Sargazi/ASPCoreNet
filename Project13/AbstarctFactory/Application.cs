using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstarctFactory.Interfaces;

namespace AbstarctFactory
{
    public class Application
    {
        private readonly IFileLogger _fileLogger;
        private readonly IDatabaseLogger _databaseLogger;

        public Application(ILogger logger)
        {
            _fileLogger = logger.CreateFileLogger();
            _databaseLogger = logger.CreateDatabaseLogger();
        }

        public void Run()
        {
            _fileLogger.logFile();
            _databaseLogger.logFile();
        }
    }
}