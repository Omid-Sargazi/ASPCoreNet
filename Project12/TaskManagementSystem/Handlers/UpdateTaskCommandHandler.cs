using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementSystem.Commands;
using TaskManagementSystem.Models;
using TaskManagementSystem.Responses;

namespace TaskManagementSystem.Handlers
{
    public class UpdateTaskCommandHandler : CommandHandler<UpdateTaskCommand, CommandResponse>
    {
        private static readonly Dictionary<string, Taskes> Taskes = new Dictionary<string, Taskes>();
        public override Task<CommandResponse> Execute(UpdateTaskCommand command, CancellationToken cancellationToken)
        {
            if(cancellationToken.IsCancellationRequested)
                return Task.FromResult(CommandResponseCanceled.CreateCanceled(command.TaskId,command.TaskName));
            
            if(Taskes.TryGetValue(command.TaskId, out var taskes))
            {
                taskes.TaskName = command.TaskName;
                taskes.Description = command.NewDescription;
                return Task.FromResult(CommandResponseSuccessful.CreateSuccessful(command.TaskId, command.TaskName));
            }

            return Task.FromResult(CommandResponseFailed.CreateFailed(command.TaskId,command.TaskName,"Task not found."));
        }
    }
}