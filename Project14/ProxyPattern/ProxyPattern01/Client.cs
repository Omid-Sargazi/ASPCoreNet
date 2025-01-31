using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern.ProxyPattern01
{
    public class Client
    {
        public void Execute(ISubject subject)
        {
            subject.Request();
        }
    }
}