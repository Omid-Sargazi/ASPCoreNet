using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantOrderSystem.Commands;
using RestaurantOrderSystem.Responses;

namespace RestaurantOrderSystem.Handlers
{
    public class CancelOrderCommandHandler : CommandHandler<CancelOrderCommand, CommandResponse>
    {
        public override Task<CommandResponse> Execute(CancelOrderCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}