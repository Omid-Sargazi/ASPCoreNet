using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProxyPattern.ProxyPattern01;

namespace ProxyPattern.AccessControlProxy
{
    public class AccessControlProxy : ISubject
    {
        private RealSubject _realSubject;
        private string _userRole;

        public AccessControlProxy(string userRole)
        {
            _userRole = userRole;
        }
        public void Request()
        {
            if(_userRole == "Admin")
            {
                if(_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                _realSubject.Request();
            }
            else{
                Console.WriteLine("AccessControlProxy: Access Denied.");
            }
        }
    }
}