namespace DesignPatterns.Creational.Factory.Common.Pizza
{
    using System.Collections.Generic;

    public abstract class Pizza : IPizza
    {
        protected Pizza(IList<string> ingredients)
        {
            this.Toppings = ingredients;
        }

        public DoughType Dough { get; set; }
        public string SauceType { get; set; }
        public string Seasonings { get; set; }
        public IList<string> Toppings { get; }

        public abstract void Bake();

        public abstract void Box();

        public abstract void Cut();
    }
}
