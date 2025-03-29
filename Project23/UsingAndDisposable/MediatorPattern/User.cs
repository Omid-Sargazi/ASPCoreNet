using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern
{
    public class User
    {
        public string Name {get; set;}
        private IChatRoom _chatRoom;
        public User(IChatRoom chatRoom, string name)
        {
            Name = name;
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            _chatRoom.SendMessage(message, this);
        }
    }
}