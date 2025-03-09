using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonPattern.SingletonPattern
{
    public class BasicSingleton
    {
        private static BasicSingleton _instance;

        private BasicSingleton()
        {

        }

        public static BasicSingleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new BasicSingleton();
            }
            return _instance;
        }

        public void SomeBusinessLogic()
        {
            
        }
    }
}