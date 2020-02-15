namespace DesignPatterns.Creational.Factory.C_AbstractFactory
{
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;

    public class CaliforniaPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new CaliforniaPizza(ingredients);
        }
    }

    public class ChicagoPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new ChicagoPizza(ingredients);
        }
    }

    public class NewYorkPizzaFactory : PizzaFactory
    {
        public override IPizza CreatePizza(IList<string> ingredients)
        {
            return new NewYorkPizza(ingredients);
        }
    }

    public abstract class PizzaFactory : IPizzaFactory
    {
        public abstract IPizza CreatePizza(IList<string> ingredients);
    }
}
