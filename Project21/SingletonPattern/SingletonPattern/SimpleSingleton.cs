using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern.SingletonPattern
{
    public sealed class SimpleSingleton
    {
        private static readonly SimpleSingleton instance = new SimpleSingleton();

        private SimpleSingleton()
        {}

        public static SimpleSingleton Instance => instance;
    }
}