using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIAuthenticationTest.API.Contracts.Abstracts.CommandAbstract;

namespace APIAuthenticationTest.API.Interfaces
{
    public interface IDistributor
    {
        Task<TCommandResponse> PushCommand<TCommand, TCommandResponse>(TCommand command, CancellationToken cancellationToken)
        where TCommand : Command where TCommandResponse :CommandResponse;

        Task<TQueryResponse> PullQuery<TQuery, TQueryResponse>(TQuery query, CancellationToken cancellationToken)
        where TQuery :Query where TQueryResponse : QueryResponse;
    }
}