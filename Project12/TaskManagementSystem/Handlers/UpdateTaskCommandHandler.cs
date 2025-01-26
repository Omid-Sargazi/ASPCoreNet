using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementSystem.Commands;
using TaskManagementSystem.Responses;

namespace TaskManagementSystem.Handlers
{
    public class UpdateTaskCommandHandler : CommandHandler<UpdateTaskCommand, CommandResponse>
    {
        public override Task<CommandResponse> Execute(UpdateTaskCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}