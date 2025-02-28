using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIPractice.DIFirstProject
{
    public class Salutation
    {
        private readonly IMessageWriter _messageWriter;
        
        public Salutation(IMessageWriter messageWriter) => _messageWriter = messageWriter;

        public void Exclaim()=> _messageWriter.Write("Hello DI!");
    }
}