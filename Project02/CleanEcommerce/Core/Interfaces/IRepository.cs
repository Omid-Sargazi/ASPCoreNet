using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T?>> GetAllAsync();
        Task AddAsync(T entity);
        Task DeleteAsync(Task entity);
        Task UpdateAsync(T entity);

    }
}