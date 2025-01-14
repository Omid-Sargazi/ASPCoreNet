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
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBooksQuery, List<BookDto>>
    {
        private readonly IBookRepository _repository;
        private readonly IMapper _mapper;

        public GetAllBookQueryHandler(IBookRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<BookDto>> Handle(GetAllBooksQuery request, CancellationToken cancellationToken)
        {
            var books = await _repository.GetAllAsync();

            var bookDtos = _mapper.Map<List<BookDto>>(books);
            return bookDtos;
        }
    }
}