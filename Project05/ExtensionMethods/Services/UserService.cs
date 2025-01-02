using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtensionMethods.Extentions;
using ExtensionMethods.Models;

namespace ExtensionMethods.Services
{
    public class UserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                 new User { Id = 1, Name = "Alice", Age = 25, Email = "alice@example.com" },
                new User { Id = 2, Name = "Bob", Age = 30, Email = "bob@example.com" },
                new User { Id = 3, Name = "Charlie", Age = 35, Email = "charlie@example.com" }
            };
        }

        public IEnumerable<User> GetFilteredUsers(string name, int? minAge, int? maxAge)
        {
            return _users.AsQueryable().ApplyFilters(name, minAge, maxAge).ToList();
        }
    }
}