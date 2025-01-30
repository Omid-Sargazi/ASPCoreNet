using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatternExample.Models
{
    public class SessionManager
    {
        private readonly UserSession _userSession;

        public SessionManager(UserSession userSession)
        {
            _userSession = new UserSession
            {
                UserId = "DefaultUser",
                Roles = new List<string>{"Guest"},
                Preferences = new Dictionary<string, string>{{"Theme","Dark"}},
                ExpirationTime = DateTime.Now.AddHours(1)
            };

            Console.WriteLine("Prototype session created.");
        }

        public UserSession CreateSession(string userId, List<string> roles, Dictionary<string,string> preference)
        {
            var newSession = (UserSession)_userSession.Clone();
            newSession.UserId = userId;
            newSession.Roles = roles;
            newSession.Preferences = preference;
            newSession.ExpirationTime = DateTime.Now.AddDays(1);

            return newSession;
        }

    }
}