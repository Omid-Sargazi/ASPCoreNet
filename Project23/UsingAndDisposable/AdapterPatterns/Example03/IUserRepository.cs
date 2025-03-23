using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAndDisposable.AdapterPatterns.Exaple01;

namespace UsingAndDisposable.AdapterPatterns.Example03
{
    public interface IUserRepository
    {
        public User GetUserById(int id);
    }
}