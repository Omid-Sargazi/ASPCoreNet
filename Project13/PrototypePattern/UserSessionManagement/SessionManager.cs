using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.UserSessionManagement
{
    public class SessionManager
    {
        private readonly UserSession _prototypeSession;

       public SessionManager()
       {
            _prototypeSession = new UserSession
            {
                UserId = "DefaultUser",
                Roles= new List<string>{"Guest"},
                Performances = new Dictionary<string, string>{{"Theme","Light"}},
                ExpirationTime = DateTime.Now.AddHours(1),
            };

            Console.WriteLine("Prototype session created.");
       }

       public UserSession CreateSession(string userId, List<string> roles, Dictionary<string,string> preferences)
       {
            var newSession = (UserSession)_prototypeSession.Clone();
            newSession.UserId = userId;
            newSession.Roles =roles;
            newSession.Performances = preferences;
            newSession.ExpirationTime = DateTime.Now.AddHours(1);
            return newSession;
       }
    }
}