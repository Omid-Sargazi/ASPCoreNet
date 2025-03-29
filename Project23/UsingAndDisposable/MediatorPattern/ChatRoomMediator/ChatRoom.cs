using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.ChatRoomMediator
{
    public class ChatRoom : IChatRoomMediator
    {
        private List<User> _users = new List<User>();
        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"{user.Name} به چت‌روم اضافه شد.");
        }

        public void SendMessage(string message, User user)
        {
            
        }
    }
}