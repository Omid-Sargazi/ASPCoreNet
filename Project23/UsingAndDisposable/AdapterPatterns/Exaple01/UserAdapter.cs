using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Exaple01
{
    public class UserAdapter
    {
        private readonly LegacyUserService _legacyUserService;
        public UserAdapter(LegacyUserService legacyUserService)
        {
            _legacyUserService = legacyUserService;
        }

        public User GetUser()
        {
            var data = _legacyUserService.GetUserData();
            var parts =  data.Split(',');
            return new User{
                Name = parts[0].Split(":")[1],
                Age = int.Parse(parts[1].Split(":")[1])
            };
        }
    }
}