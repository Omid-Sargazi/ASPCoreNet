using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookstoreManagement.Domain.Entities;

namespace BookstoreManagement.Application.Interfaces
{
    public interface IInventoryRepository
    {
         Task<Inventory> GetByIdAsync(int id);
        Task AddAsync(Inventory author);
        Task UpdateAsync(Inventory author);
        Task DeleteAsync(int id);
        Task<List<Inventory>> GetAllAsync();
    }
}