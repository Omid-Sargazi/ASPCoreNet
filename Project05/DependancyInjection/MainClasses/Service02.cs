using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependancyInjection.Interfaces;

namespace DependancyInjection.MainClasses
{
    public class Service02
{
        public ILogger logger {get;set;}

    public void PerformTask()
    {
        logger.Log("Performing task02");
    }
}

}
