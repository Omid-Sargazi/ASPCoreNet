using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.PlaceOrder
{
    public class CommandResponseCanceled:CommandResponse
    {
        public CommandResponseCanceled():base("Error", 0, "Operation was canceled")
        {
            
        }

        public static CommandResponse CreateCanceled()
        {
            return new CommandResponseCanceled();           
        }
    }
}