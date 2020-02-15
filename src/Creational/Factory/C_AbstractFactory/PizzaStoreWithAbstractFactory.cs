namespace DesignPatterns.Creational.Factory.C_AbstractFactory
{
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;

    public abstract class PizzaStoreWithAbstractFactory
    {
        private readonly IPizzaFactory _factory;

        protected PizzaStoreWithAbstractFactory(IPizzaFactory factory)
        {
            _factory = factory;
        }

        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = _factory.CreatePizza(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
