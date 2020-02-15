namespace DesignPatterns.Creational.Factory.B_FactoryMethod
{
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;

    /*
     The base class from Factory Method aproach
    */

    public class CaliforniaPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            //This is tied to a specific pizza implementation
            return new CaliforniaPizza(ingredients);
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            //This is tied to a specific pizza implementation
            return new ChicagoPizza(ingredients);
        }
    }

    public class NewYorkPizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            //This is tied to a specific pizza implementation
            return new NewYorkPizza(ingredients);
        }
    }

    public abstract class PizzaStore
    {
        public abstract IPizza CreatePizza(IList<string> ingredients);

        public IPizza OrderPizza(IList<string> ingredients)
        {
            IPizza pizza = this.CreatePizza(ingredients);
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
