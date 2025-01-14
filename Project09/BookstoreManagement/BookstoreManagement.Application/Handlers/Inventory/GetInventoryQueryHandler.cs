using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookstoreManagement.Application.DTOs;
using BookstoreManagement.Application.Interfaces;
using BookstoreManagement.Application.Queries;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Inventory
{
    public class GetInventoryQueryHandler : IRequestHandler<GetInventoryQuery, InventoryDto>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;
        public GetInventoryQueryHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }
        public async Task<InventoryDto> Handle(GetInventoryQuery request, CancellationToken cancellationToken)
        {
            var inventory = await _inventoryRepository.GetByIdAsync(request.Id);

            if(inventory == null)
                throw new Exception($"Inventory with ID {request.Id} not found.");
            
            return _mapper.Map<InventoryDto>(inventory);
        }
    }
}