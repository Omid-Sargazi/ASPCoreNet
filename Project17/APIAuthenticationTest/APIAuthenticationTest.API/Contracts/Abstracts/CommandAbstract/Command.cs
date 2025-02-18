using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract
{
    public abstract class Command
    {
        public Command()
        {
            MetaData = new MetaData();   
        }
        [JsonIgnore] public MetaData MetaData {get; set;}    
    }
}