using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAndDisposable.AdapterPatterns.Exaple01;

namespace UsingAndDisposable.AdapterPatterns.Example03
{
    public class DatabaseAdapter : IUserRepository
    {
        private readonly OldDatabase _oldDatabase;
        public DatabaseAdapter(OldDatabase oldDatabase)
        {
            _oldDatabase = oldDatabase;
        }
        public User GetUserById(int id)
        {
            var data = _oldDatabase.FetchData();
            var parts = data.Split(',');
            return new User
            {
                Name = parts[1].Split(':')[1],
            };
        }
    }
}