using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProxyPattern.ProxyPattern01;

namespace ProxyPattern.LazyProxy
{
    public class LazyProxy : ISubject
    {
        private RealSubject _realSubject;

        public void Request()
        {
            if(_realSubject == null)
            {
                Console.WriteLine("LazyProxy: Initializing RealSubjects;");
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}