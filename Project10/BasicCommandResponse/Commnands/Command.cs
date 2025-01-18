using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Data;

namespace BasicCommandResponse.Commnands
{
    public abstract class Command
    {
        public Metadata Metadata {get; set;}
        public Command()
        {
            Metadata = new Metadata();
        }
    }
}