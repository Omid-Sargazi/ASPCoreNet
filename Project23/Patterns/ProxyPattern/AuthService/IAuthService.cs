using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patterns.ProxyPattern.AuthService
{
    public interface IAuthService
    {
        bool Authenticate(string userName, string Password);
    }
}