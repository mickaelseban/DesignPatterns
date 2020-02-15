namespace DesignPatterns.Creational.Factory.C_AbstractFactory
{
    public class NewYorkPizzaStoreWithAbstractFactory : PizzaStoreWithAbstractFactory
    {
        public NewYorkPizzaStoreWithAbstractFactory() : this(new NewYorkPizzaFactory())
        {
        }

        public NewYorkPizzaStoreWithAbstractFactory(IPizzaFactory factory) : base(factory)
        {
        }
    }
}
