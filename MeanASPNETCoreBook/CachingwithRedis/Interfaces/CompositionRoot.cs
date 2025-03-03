using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CachingwithRedis.Interfaces
{
    public class CompositionRoot
    {
        public static App BuildApp(string configValue)
        {
            IGreeter greeter = configValue == "Email"? new EmailGreeter("smtp.server.com")
            :new FileGreeter("C:\\Temp\\GreetingLog.txt");

            return new App(greeter);
        }
    }
}