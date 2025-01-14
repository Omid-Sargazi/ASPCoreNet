using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Application.Commands;
using BookstoreManagement.Application.Interfaces;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Book
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand,Unit>
    {

        private readonly IBookRepository _repository;

        public DeleteBookCommandHandler(IBookRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetByIdAsync(request.Id);

            if(book == null)
                throw new Exception($"Book with ID {request.Id} not found.");

            await _repository.DeleteAsync(request.Id);
            return Unit.Value;
            
        }
    }
}