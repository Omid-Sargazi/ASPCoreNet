using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookstoreManagement.Application.DTOs;
using BookstoreManagement.Application.Interfaces;
using BookstoreManagement.Application.Queries;
using MediatR;

namespace BookstoreManagement.Application.Handlers.Book
{
    public class GetBookQueryHandler:IRequestHandler<GetBookQuery,BookDto>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public GetBookQueryHandler(IBookRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<BookDto> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            var book = await _repository.GetByIdAsync(request.Id);
            if(book == null)
                throw new Exception($"Book with ID {request.Id} not found.");

            return _mapper.Map<BookDto>(book);
        }
    }
}