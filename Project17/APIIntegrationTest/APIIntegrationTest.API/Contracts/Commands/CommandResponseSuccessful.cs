using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntegrationTest.API.Contracts.Commands
{
    public class CommandResponseSuccessful : CommandResponse
    {
        public CommandResponseSuccessful():base(ResponseCodes.OperationSuccessful)
        {
            
        }

        public static CommandResponse CreateSuccessful()
        {
            return new CommandResponseSuccessful();
        }
    }
}