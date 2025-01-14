using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.Commands.Inventory;
using BookstoreManagement.Application.Interfaces;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Inventory
{
    public class DeleteInventoryCommandHandler : IRequestHandler<DeleteInventoryCommand, Unit>
    {
        private readonly IInventoryRepository _inventoryRepository;

        public DeleteInventoryCommandHandler(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }
        public async Task<Unit> Handle(DeleteInventoryCommand request, CancellationToken cancellationToken)
        {
            var inventory = await _inventoryRepository.GetByIdAsync(request.Id);

            if(inventory ==null)
                throw new Exception($"Inventory with ID {request.Id} not found.");

            await _inventoryRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}