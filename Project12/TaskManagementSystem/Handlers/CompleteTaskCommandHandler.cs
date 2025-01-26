using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementSystem.Commands;
using TaskManagementSystem.Models;
using TaskManagementSystem.Responses;

namespace TaskManagementSystem.Handlers
{
    public class CompleteTaskCommandHandler : CommandHandler<CompleteTaskCommand, CommandResponse>
    {
        private static readonly Dictionary<string, Taskes> Taskes = new Dictionary<string, Taskes>();
        public override Task<CommandResponse> Execute(CompleteTaskCommand command, CancellationToken cancellationToken)
        {
            if(cancellationToken.IsCancellationRequested)
                return Task.FromResult(CommandResponseCanceled.CreateCanceled(command.TaskId,command.TaskName,"Task completion canceled."));

            if(Taskes.TryGetValue(command.TaskId, out var taskes))
            {
                taskes.IsCompleted = true;
                return Task.FromResult(CommandResponseSuccessful.CreateSuccessful(command.TaskId, command.TaskName, "Task completed successfully."));
            }

            return Task.FromResult(CommandResponseFailed.CreateFailed(command.TaskId, "Unknown Task", "Task not found."));
        }
    }
}