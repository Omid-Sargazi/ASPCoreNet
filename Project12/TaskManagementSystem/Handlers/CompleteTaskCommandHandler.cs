using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementSystem.Commands;
using TaskManagementSystem.Responses;

namespace TaskManagementSystem.Handlers
{
    public class CompleteTaskCommandHandler : CommandHandler<CompleteTaskCommand, CommandResponse>
    {
        public override Task<CommandResponse> Execute(CompleteTaskCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}