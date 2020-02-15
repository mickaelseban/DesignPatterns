namespace DesignPatterns.Creational.Factory.C_AbstractFactory
{
    public class CaliforniaPizzaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public CaliforniaPizzaStoreWithAbstractFactory() : this(new CaliforniaPizzaFactory())
        {
        }

        public CaliforniaPizzaStoreWithAbstractFactory(IPizzaFactory factory) : base(factory)
        {
        }
    }
}
