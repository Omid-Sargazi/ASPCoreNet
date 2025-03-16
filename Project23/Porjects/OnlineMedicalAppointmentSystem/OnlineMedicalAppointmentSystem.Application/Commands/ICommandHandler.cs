using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalAppointmentSystem.Application.Commands
{
    public interface ICommandHandler<TCommand>
    {
        Task Handle(TCommand command);
    }
}