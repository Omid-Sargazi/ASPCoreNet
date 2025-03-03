using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingwithRedis.Interfaces
{
    public class EmailGreeter : IGreeter
    {
        private string _smtpServer;
        public EmailGreeter(string smtpServer)
        {
            
            _smtpServer = smtpServer;
        }
        public void Greet(string message)
        {
            Console.WriteLine($"Emailing via {_smtpServer}: {message}");
        }
    }
}