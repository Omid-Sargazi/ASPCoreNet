using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIntegrationTest.API.Contracts.Commands;

namespace APIIntegrationTest.API.Contracts.Query
{
    public abstract class Query
    {
        public Query()
        {
            Metadata = new Metadata();   
        }

        public Metadata Metadata {get; set;}   
    }
}