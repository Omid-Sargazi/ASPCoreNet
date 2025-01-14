using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.Commands;
using BookstoreManagement.Application.Interfaces;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Book
{
    public class UpdateBookCommandHandler : IRequestHandler<UpdateBookCommand,Unit>
    {
        private readonly IBookRepository _repository;

        public UpdateBookCommandHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetByIdAsync(request.Id);
            if(book ==null)
                throw new Exception($"Book with ID {request.Id} not found.");
            
            book.Update(request.Title,request.Price, request.AuthorId, request.CategoryId);
            await _repository.UpdateAsync(book);
            return Unit.Value;
        }
    }
}