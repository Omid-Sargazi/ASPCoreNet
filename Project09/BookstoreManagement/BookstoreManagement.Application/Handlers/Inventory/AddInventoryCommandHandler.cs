using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookstoreManagement.Application.Commands.Inventory;
using BookstoreManagement.Application.Interfaces;
using BookstoreManagement.Domain.Entities;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Inventory
{
    public class AddInventoryCommandHandler : IRequestHandler<AddInventoryCommand, int>
    {
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public AddInventoryCommandHandler(IInventoryRepository repository, IMapper mapper, IBookRepository bookRepository)
        {
            _inventoryRepository = repository;
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
        public async Task<int> Handle(AddInventoryCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetByIdAsync(request.BookId);

            if(book == null)
                throw new Exception($"Book with ID {request.BookId} does not exist.");
            
            var inventory = new Domain.Entities.Inventory(request.BookId, request.Quantity);

            return inventory.Id;

        }
    }
}