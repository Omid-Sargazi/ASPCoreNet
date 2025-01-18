using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCommandResponse.Commnands
{
    public abstract class CommandHandler<TCommand, TResponse> where TCommand:Command where TResponse:CommandResponse
    {
        public abstract Task<TResponse> Executer(TCommand command, CancellationToken cancellationToken);
    }
}