namespace DesignPatterns.Creational.Singleton
{
    /*
        Thread-Safe initialization
    */

    public sealed class SingletonClass
    {
        /*private fields*/
        private static readonly object _syncLock = new object();
        private static volatile SingletonClass _instance;

        private SingletonClass()
        {
        }

        public static SingletonClass Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClass();
                    }
                }
                return _instance;
            }
        }

        public int SomeValue { get; set; }
    }
}
