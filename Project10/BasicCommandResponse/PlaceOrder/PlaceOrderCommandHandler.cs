using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCommandResponse.Commnands;

namespace BasicCommandResponse.PlaceOrder
{
    public class PlaceOrderCommandHandler : CommandHandler<PlaceOrderCommand, CommandResponse>
    {
        private bool CheckInventory(string productName, int quantity)
        {
            const int stock = 10;
            return quantity <=stock;
        }
        public override async Task<CommandResponse> Executer(PlaceOrderCommand command, CancellationToken cancellationToken)
        {
            if(CheckInventory(command.ProductName, command.Quantity))
            {
                return new CommandResponse
                {
                    Prefix = "Errro"
                    Code=400,
                    Message="Insufficient stock"
                };
            }
            Console.WriteLine($"Processing payment for {command.Quantity} of {command.ProductName}...");

            Console.WriteLine($"Order placed for {command.Quantity} of {command.ProductName} by Customer {command.CustomerId}");

        // Return a success response
        return new CommandResponse
        {
            Prefix = "Success",
            Code = 200,
            Message = "Order placed successfully"
        };

        }
    }
}