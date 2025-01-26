using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantOrderSystem.Commands;
using RestaurantOrderSystem.Responses;

namespace RestaurantOrderSystem.Handlers
{
    public class ModifyOrderCommandHandler : CommandHandler<ModifyOrderCommand, CommandResponse>
    {
        public override Task<CommandResponse> Execute(ModifyOrderCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}