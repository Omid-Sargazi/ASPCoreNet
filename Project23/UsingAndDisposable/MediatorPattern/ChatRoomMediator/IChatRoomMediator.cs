using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.ChatRoomMediator
{
    public interface IChatRoomMediator
    {
        public  void SendMessage(string message, User user);
        public void AddUser(User user);
    }
}