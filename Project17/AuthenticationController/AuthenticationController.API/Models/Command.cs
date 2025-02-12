using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationController.API.Models
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