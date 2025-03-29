using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.MediatorPattern.ChatRoomMediator
{
    public class User
    {
        private IChatRoomMediator _mediator;
        public string Name {get; set;}
        public User(string name,IChatRoomMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }
        public void SendMessage(string message)
        {
            Console.WriteLine($"{Name} می‌گه: {message}");
            _mediator.SendMessage(message,this);
        }


        public void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"{Name} پیام دریافت کرد از {senderName}: {message}");
        }
    }
}