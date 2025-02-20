using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSPattern02.API.Contracts.Markers;

namespace CQRSPattern02.API.Services
{
    public class CommandDistributor : IDistributor
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandDistributor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;   
        }
        public async Task<TResponse> PushCommand<TCommand, TResponse>(TCommand command, CancellationToken cancellationToken) where TCommand : ICommand
        {
            var handler = _serviceProvider.GetService<ICommandHandler<TCommand, TResponse>>();
            if(handler == null)
                throw new InvalidOperationException($"No handler registered for {typeof(TCommand).Name}");
            
            return await handler.Handle(command,cancellationToken);
        }
    }
}