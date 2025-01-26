using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantOrderSystem.Commands;
using RestaurantOrderSystem.Responses;

namespace RestaurantOrderSystem.Handlers
{
    public class PlaceOrderCommandHandler : CommandHandler<PlaceOrderCommand, CommandResponse>
    {
        public override Task<CommandResponse> Execute(PlaceOrderCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}