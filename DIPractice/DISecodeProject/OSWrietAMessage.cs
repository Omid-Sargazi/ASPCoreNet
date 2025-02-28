using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIPractice.DISecodeProject
{
    public class OSWrietAMessage
    {
        private readonly IWriteAMessage _writeAMessage;

        public OSWrietAMessage(IWriteAMessage writeAMessage)
        {
            _writeAMessage = writeAMessage;
        }

        public void Write(string message)
        {
            _writeAMessage.Write(message);
        }
    }
}