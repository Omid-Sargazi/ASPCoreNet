using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class SimpleDispatcher
    {
        public event Action<string> OnMessage;

        public void Dispatch(string message)
        {
            OnMessage?.Invoke(message);
        }
    }
}