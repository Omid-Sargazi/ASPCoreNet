using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.Users
{
    public class CreateUserManager
    {
        private readonly CreateUsers _createUsers;

        public CreateUserManager()
        {
            _createUsers = new CreateUsers
            {
                UserId = "DafaultUser",
                Roles = new List<string>{"Guest"},
                Preferences = new Dictionary<string, string>
                {
                    {"Theme", "Light"},
                },
                ExpirationTime = DateTime.Now.AddHours(1)
            };

            Console.WriteLine("user created.");
        }

        public CreateUsers createUsers(string userId, List<string> roles, Dictionary<string, string> preference)
        {
            var newCreatedUser = (CreateUsers)_createUsers.Clone();
            _createUsers.UserId = userId;
            _createUsers.Roles = roles;
            _createUsers.Preferences = preference;
            _createUsers.ExpirationTime = DateTime.Now.AddDays(1);

            return newCreatedUser;
        }


    }
}