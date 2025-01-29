using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePatterns.Models
{
    public class UserSession : ICloneable
    {
        public string UserId {get; set;}
        public List<string> Roles {get; set;}
        public Dictionary<string, string> Preferences {get; set;}
        public DateTime ExpirationTime {get; set;}

        public UserSession()
        {
            Roles = new List<string>();
            Preferences = new Dictionary<string, string>();
        }
        public object Clone()
        {
           var clonedSession = (UserSession)this.MemberwiseClone();
           clonedSession.Roles = new List<string>(this.Roles);
           clonedSession.Preferences = new Dictionary<string, string>(this.Preferences);

           return clonedSession;
        }

        public void Dispaly()
        {
            Console.WriteLine($"UserId:{UserId}");
            Console.WriteLine($"ExpirationTime: {ExpirationTime}");
            Console.WriteLine("Roles: ");
            foreach(var role in Roles)
                Console.WriteLine($"{role}");

            Console.WriteLine("Preferences:");
            foreach (var preference in Preferences)
            {
                Console.WriteLine($"-{preference.Key}, {preference.Value}");
            }
        }
    }
}