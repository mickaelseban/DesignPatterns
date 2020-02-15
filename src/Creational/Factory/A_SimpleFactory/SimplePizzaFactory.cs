namespace DesignPatterns.Creational.Factory.A_SimpleFactory
{
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;

    public class SimplePizzaFactory
    {
        public static IPizza CreatePizza(PizzaType type, IList<string> ingredients)
        {
            switch (type)
            {
                case PizzaType.NewYork:
                    return new NewYorkPizza(ingredients);

                case PizzaType.Chicago:
                    return new ChicagoPizza(ingredients);

                case PizzaType.California:
                    return new CaliforniaPizza(ingredients);

                default:
                    return null;
            }
        }
    }
}
