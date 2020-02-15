namespace DesignPatterns.Creational.Singleton
{
    /*
     Non Thread-Safe and Lazy Initialization
     */

    public sealed class SingletonSealedClass
    {
        private static readonly SingletonSealedClass _instance = new SingletonSealedClass();

        private SingletonSealedClass()
        {
        }

        public static SingletonSealedClass Instance => _instance;

        public int SomeValue { get; set; }
    }
}
