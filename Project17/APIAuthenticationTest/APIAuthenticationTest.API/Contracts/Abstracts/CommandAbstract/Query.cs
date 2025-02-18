using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract
{
    public abstract class Query
    {
        protected Query()
        {
            MetaData = new MetaData();
        }   

        [JsonIgnore] public MetaData MetaData {get; set;}
    }
}