using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicalAppointmentSystem.Domain.Models;

namespace OnlineMedicalAppointmentSystem.Infrastructure.Repositories
{
    public interface IRepository<T> where T:BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}