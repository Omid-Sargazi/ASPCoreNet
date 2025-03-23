using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAndDisposable.AdapterPatterns.Exaple01
{
    public class LegacyUserService
    {
        public string GetUserData() => "Name:Omid,Age:42";
    }
}