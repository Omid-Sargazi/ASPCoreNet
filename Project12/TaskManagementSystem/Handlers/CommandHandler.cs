using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagementSystem.Commands;

namespace TaskManagementSystem.Handlers
{
    public abstract class CommandHandler<TCommand, TResponse> where TCommand :Command
    {
        public abstract Task<TResponse> Execute(TCommand command, CancellationToken cancellationToken);
    }
}