using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.Commands;
using BookstoreManagement.Application.Interfaces;
using BookstoreManagement.Domain.Entities;
using MediatR;

namespace BookstoreManagement.Application.Handlers
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, int>
    {
        private readonly IBookRepository _bookRepository;

        public AddBookCommandHandler(IBookRepository repository)
        {
            _bookRepository = repository;
        }
        public async Task<int> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Book(request.Title, request.Price, request.AuthorId, request.CategoryId);
            await _bookRepository.AddAsync(book);
            return book.Id;
        }
    }
}