using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using AutoMapper;
using BookstoreManagement.Application.Commands;
using BookstoreManagement.Application.Commands.Category;
using BookstoreManagement.Application.Interfaces;
using BookstoreManagement.Domain.Entities;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Book
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IInventoryRepository _inventoryRepository;
        private readonly IMapper _mapper;

        public AddBookCommandHandler(IBookRepository bookRepository, IAuthorRepository authorRepository, ICategoryRepository categoryRepository, IInventoryRepository inventoryRepository ,IMapper mapper)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _categoryRepository = categoryRepository;
            _inventoryRepository = inventoryRepository;
        }

        public async Task<int> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var author = await _authorRepository.GetByIdAsync(request.AuthorId);
            if(author==null)
            {
                throw new ArgumentException($"Author with ID {request.AuthorId} does not exist.");
            }

            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if (category == null)
            {
                throw new ArgumentException($"Category with ID {request.CategoryId} does not exist.");
            }

            var book = new BookstoreManagement.Domain.Entities.Book(request.Title, request.Price, request.AuthorId, request.CategoryId);
            await _bookRepository.AddAsync(book);

            var inventory = new Domain.Entities.Inventory(book.Id, request.InventoryQuantity);
            await _inventoryRepository.AddAsync(inventory);

            return book.Id;
        }
    }
}