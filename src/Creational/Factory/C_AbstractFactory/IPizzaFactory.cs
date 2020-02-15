namespace DesignPatterns.Creational.Factory.C_AbstractFactory
{
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;

    public interface IPizzaFactory
    {
        IPizza CreatePizza(IList<string> ingredients);
    }
}
