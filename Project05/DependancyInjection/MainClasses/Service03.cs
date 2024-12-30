using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependancyInjection.Interfaces;

namespace DependancyInjection.MainClasses
{
    public class Service03
    {
        public void PerformTask(ILogger logger)
        {
            logger.Log("Task performed.");
        }
    }
}