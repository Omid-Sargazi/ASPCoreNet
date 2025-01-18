using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.Account
{
    public class CommandResponseSuccessful:CommandResponse
    {
        public CommandResponseSuccessful():base()
        {
            
        }

        public static CommandResponse CreateSuccessful()
        {
            return new CommandResponseSuccessful()
        }
    }
}