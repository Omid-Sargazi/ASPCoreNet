using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;
using BasicCommandResponse.PlaceOrder;

namespace BasicCommandResponse.payment
{
    public class ProcessPaymentCommandHandler : CommandHandler<ProcessPaymentCommand, CommandResponse>
    {

        private bool IsValidPayment(double amount)
        {
            return amount>0;
        }


        public override async Task<CommandResponse> Executer(ProcessPaymentCommand command, CancellationToken cancellationToken)
        {
            if(!IsValidPayment(command.Amount))
            {
                return CommandResponseCanceled.CreateCanceled(); 
            }

            Console.WriteLine($"Processing payment of {command.Amount} using {command.PaymentMethod}...");
            
            return new CommandResponse
        {
            Prefix = "Success",
            Code = 200,
            Message = $"Payment of {command.Amount} was successful"
        };

        }
    }
}