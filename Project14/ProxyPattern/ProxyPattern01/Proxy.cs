using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern.ProxyPattern01
{
    public class Proxy : ISubject
    {
        private  RealSubject _realSubject;

        
        public void Request()
        {
            if(_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            Console.WriteLine("Proxy:Logging the request;");
            _realSubject.Request();
        }
    }
}