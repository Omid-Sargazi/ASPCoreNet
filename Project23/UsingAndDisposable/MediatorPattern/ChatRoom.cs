using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern
{
    public class ChatRoom : IChatRoom
    {
        public void SendMessage(string message, User user)
        {
            Console.WriteLine($"{user.Name} says: {message}");
        }
    }
}