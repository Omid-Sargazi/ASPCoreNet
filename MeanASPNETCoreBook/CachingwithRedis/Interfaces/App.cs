using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingwithRedis.Interfaces
{
    public class App
    {
        private readonly IGreeter _greeter;
        public App(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public void Run()
        {
            _greeter.Greet("Hello World!");
        }
    }
}