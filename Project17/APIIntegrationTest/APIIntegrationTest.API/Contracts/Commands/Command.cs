using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands
{
    public abstract class Command
    {
        public Command()
        {
            Metadata = new Metadata();
        }
        public Metadata Metadata {get; set;}   
    }
}