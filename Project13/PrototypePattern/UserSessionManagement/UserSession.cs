using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.UserSessionManagement
{
    public class UserSession : ICloneable
    {
        public string UserId {get; set;}
        public List<string> Roles {get; set;}
        public Dictionary<string, string> Performances {get; set;}
        public DateTime ExpirationTime {get; set;}

        public UserSession()
        {
            Roles = new List<string>();
            Performances = new Dictionary<string, string>();
        }
        public object Clone()
        {
            var clonedSession = (UserSession)this.MemberwiseClone();
            clonedSession.Performances = new Dictionary<string, string>(this.Performances);
            
            return clonedSession;
        }

        public void Dispaly()
        {
            Console.WriteLine($"UserId:{UserId}");
            Console.WriteLine($"ExpirationTime: {ExpirationTime}");
            Console.WriteLine("Roles: ");
            foreach(var role in Roles)
            {
                Console.WriteLine($"-{role}");
            }
            Console.WriteLine("Persormances: ");
            foreach(var performnace in Performances)
            {
                Console.WriteLine($"-{performnace.Key}, {performnace.Value}");
            }
        }
    }
}