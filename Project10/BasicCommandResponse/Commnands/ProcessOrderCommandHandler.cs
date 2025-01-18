using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCommandResponse.Commnands
{
    public class ProcessOrderCommandHandler : CommandHandler<ProcessOrderCommand, CommandResponse>
    {
        public override async Task<CommandResponse> Executer(ProcessOrderCommand command, CancellationToken cancellationToken)
        {
            if(command.Quantity <= 0)
            {
                return new CommandResponse
                {
                    Prefix="Errro",
                    Code=400,
                    Message="Invalid Quantity"
                };
                Console.WriteLine($"Processing order for {command.Quantity} of {command.ProductName}...");
            }

            return new CommandResponse
            {
                Prefix="Success",
                Code=200,
                Message="Order processed successfully"
            };
        }
    }
}