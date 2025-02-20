using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern02.API.Contracts.Markers
{
    public interface IDistributor
    {
        Task<TResponse> PushCommand<TCommand, TResponse>(TCommand command, CancellationToken cancellationToken) where TCommand :ICommand;
    }
}