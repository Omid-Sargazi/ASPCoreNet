using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.Commands.Inventory;
using BookstoreManagement.Application.Interfaces;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Inventory
{
    public class UpdateInventoryCommandHandler : IRequestHandler<UpdateInventoryCommand, Unit>
    {
        private readonly IInventoryRepository _inventoryRepository;

        public UpdateInventoryCommandHandler(IInventoryRepository repository)
        {
            _inventoryRepository = repository;
        }
        public async Task<Unit> Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
        {
            var inventory = await _inventoryRepository.GetByIdAsync(request.Id);
            if(inventory == null)
                throw new Exception($"Inventory with ID {request.Id} not found.");

            inventory.UpdateQuantity(request.Quantity);
            
            await _inventoryRepository.UpdateAsync(inventory);

            return Unit.Value;
        }
    }
}