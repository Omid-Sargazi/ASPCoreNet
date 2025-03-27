using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.DIP
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
             Console.WriteLine($"Sending email: {message}");
        }
    }
}