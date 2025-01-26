using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using TaskManagementSystem.Commands;
using TaskManagementSystem.Models;
using TaskManagementSystem.Responses;

namespace TaskManagementSystem.Handlers
{
    public class CreateTaskCommandHandler : CommandHandler<CreateTaskCommand, CommandResponse>
    {
        private static readonly Dictionary<string, Taskes> Taskes = new Dictionary<string, Taskes>();
        public override Task<CommandResponse> Execute(CreateTaskCommand command, CancellationToken cancellationToken)
        {
            if(cancellationToken.IsCancellationRequested)
                return Task.FromResult(CommandResponseCanceled.CreateCanceled(command.TaskId,command.TaskName));
            
            var task = new Taskes
            {
                TaskId = command.TaskId,
                TaskName = command.TaskName,
               Description = command.Description,
               IsCompleted = false,
            };

            Taskes.Add(command.TaskId, task);

            return Task.FromResult(CommandResponseSuccessful.
            CreateSuccessful(command.TaskId,command.TaskName,"Task created successfully."));
        }
    }
}