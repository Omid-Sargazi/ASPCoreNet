using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern.SingletonPattern
{
    public class DoubleCheckSingleton
    {
        private static DoubleCheckSingleton _instance;
        private static readonly object _lock = new object();

        private DoubleCheckSingleton()
        {}

        public static DoubleCheckSingleton GetInstance()
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                    {
                        _instance = new DoubleCheckSingleton();
                    }
                }
            }

            return _instance;
        }
    }
}