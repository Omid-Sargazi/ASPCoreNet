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
    public class GetAllInventoriesQueryHandler : IRequestHandler<GetAllInventoriesQuery, List<InventoryDto>>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public GetAllInventoriesQueryHandler(IInventoryRepository inventoryRepository, IMapper mapper)
        {
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }
        public async Task<List<InventoryDto>> Handle(GetAllInventoriesQuery request, CancellationToken cancellationToken)
        {
            var inventories  = await _inventoryRepository.GetAllAsync();
            var inventoryDtos = _mapper.Map<List<InventoryDto>>(inventories);

            return inventoryDtos; 
        }
    }
}