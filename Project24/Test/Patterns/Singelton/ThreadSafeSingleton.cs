namespace Test.Pattern.Singelton
{
    public class ThreadSafeSingleton
    {
        private static readonly object _lock = new object();
        private static ThreadSafeSingleton _instance;

        private ThreadSafeSingleton(){}

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if(_instance == null)
                        _instance = new ThreadSafeSingleton();
                    return _instance;
                }
            }
        }
        
        public void Log(string msg) => Console.WriteLine(msg);
    }
}