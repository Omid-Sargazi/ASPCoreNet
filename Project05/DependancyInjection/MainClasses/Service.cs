using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using DependancyInjection.Interfaces;

namespace DependancyInjection.MainClasses
{
    public class Service
    {
        private readonly ILogger _logger;
        public Service(ILogger logger)
        {
            _logger = logger;
        }

        public void PerformTask()
        {
            _logger.Log("Performing task");
        }
    }
}