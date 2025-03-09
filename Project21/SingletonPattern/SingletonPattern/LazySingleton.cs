using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern.SingletonPattern
{
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> _lazy = 
        new Lazy<LazySingleton>(()=>new LazySingleton());

        private LazySingleton()
        {}

        public static LazySingleton Instance => _lazy.Value;

        public void DoSomething()
        {
            Console.WriteLine("Singleton is doing something");
        }
    }
}