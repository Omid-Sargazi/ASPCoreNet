using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Injection
{
    public class UserService
    {
        private readonly ILogger _logger;
        public UserService(ILogger logger)
        {
            _logger = logger;
        }

        public void AddUser(string username)
        {
            _logger.log($"user {username}");
        }
    }
}