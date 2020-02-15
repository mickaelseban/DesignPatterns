namespace DesignPatterns.Creational.Factory.Common.Pizza
{
    using System.Collections.Generic;

    public interface IPizza
    {
        DoughType Dough { get; set; }
        string SauceType { get; set; }
        string Seasonings { get; set; }
        IList<string> Toppings { get; }

        void Bake();

        void Box();

        void Cut();
    }
}
