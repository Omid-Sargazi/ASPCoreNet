using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domin.Entities;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public class TodoRepository : ITodoRepository
    {
        public Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}