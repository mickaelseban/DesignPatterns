namespace DesignPatterns.Creational.Factory.C_AbstractFactory
{
    public class ChicagoPizzaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public ChicagoPizzaStoreWithAbstractFactory() : this(new ChicagoPizzaFactory())
        {
        }

        public ChicagoPizzaStoreWithAbstractFactory(IPizzaFactory factory) : base(factory)
        {
        }
    }
}
