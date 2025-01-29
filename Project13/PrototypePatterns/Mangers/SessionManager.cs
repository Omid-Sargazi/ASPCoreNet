using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrototypePatterns.Models;

namespace PrototypePatterns.Mangers
{
    public class SessionManager
    {
        private readonly UserSession _prototypeSession;

        public SessionManager()
        {
            _prototypeSession = new UserSession
            {
                UserId = "DefaultUser",
                Roles = new List<string>{"Guest"},
                Preferences = new Dictionary<string, string>{{"Theme","Light"}},
                ExpirationTime = DateTime.Now.AddHours(1),
            };

            Console.WriteLine("Prototype session created.");
        }

        public UserSession CreateSession(string userId, List<string> roles, Dictionary<string,string> preference)
        {
           var newSession = (UserSession)_prototypeSession.Clone();
           newSession.UserId = userId;
           newSession.Preferences = preference;
           newSession.Roles = roles;
           newSession.ExpirationTime = DateTime.Now.AddHours(1);

           return newSession;
           
        }
    }
}