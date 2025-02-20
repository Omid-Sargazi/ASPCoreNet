using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSPattern02.API.Contracts.Markers
{
    public interface ICommandHandler<in TCommand, TResponse> where TCommand:ICommand
    {
        Task<TResponse> Handle(TCommand command, CancellationToken cancellationToken);   
    }
}