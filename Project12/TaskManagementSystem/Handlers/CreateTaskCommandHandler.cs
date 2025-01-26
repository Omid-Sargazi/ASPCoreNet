using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementSystem.Commands;
using TaskManagementSystem.Responses;

namespace TaskManagementSystem.Handlers
{
    public class CreateTaskCommandHandler : CommandHandler<CreateTaskCommand, CommandResponse>
    {
        public override Task<CommandResponse> Execute(CreateTaskCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}