using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;

namespace BookstoreManagement.Application.Interfaces
{
    public interface IAuthorRepository
    {
         Task<Author> GetByIdAsync(int id);
        Task AddAsync(Author author);
        Task UpdateAsync(Author author);
        Task DeleteAsync(int id);
        Task<List<Author>> GetAllAsync();
    }
}