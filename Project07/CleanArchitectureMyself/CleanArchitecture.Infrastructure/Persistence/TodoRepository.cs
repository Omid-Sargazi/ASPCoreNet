using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domin.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ApplicationDbContext _context;
        public async Task AddAsync(TodoItem todoItem)
        {
            await _context.TodoItems.AddAsync(todoItem);
        }

        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<TodoItem> GetByIdAsync(int id)
        {
            var item = await _context.TodoItems.FindAsync(id);
            if (item == null)
            {
                throw new Exception("Item not found");
            }
            return item;
        }
    }
}