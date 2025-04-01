namespace Test.Pattern.Singelton
{
    public static class SingletonLogger
    {
        private static SingletonLogger _instance;

        private SingletonLogger(){}
        public static SingletonLogger getInstance()
        {
            get
            {
                if(_instance == null)
                    _instance = new SingletonLogger();
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"[Singleton Log] {message}");
        }
    }
}