namespace DesignPatterns.Creational.Factory.B_FactoryMethod
{
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;

    public class CaliforniaPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new CaliforniaPizza(ingredients);
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new ChicagoPizza(ingredients);
        }
    }

    public class NewYorkPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new NewYorkPizza(ingredients);
        }
    }

    public abstract class PizzaStore
    {
        public abstract IPizza CreatePizza(IList<string> ingredients);

        public IPizza OrderPizza(IList<string> ingredients)
        {
            var pizza = this.CreatePizza(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
