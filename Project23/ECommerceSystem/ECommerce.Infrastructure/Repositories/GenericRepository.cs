using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Domain.Entities;
using ECommerce.Domain.Interfaces;
using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ECommerceContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = context.Set<T>();   
        }
        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);

        public async Task DeleteAsync(T entity) =>  _dbSet.Remove(entity);

        public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<T?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public async Task UpdateAsync(T entity) =>  _dbSet.Update(entity);
    }
}