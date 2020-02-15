namespace DesignPatterns.Structural.Decorator.CoffeeExample
{
    using System.Collections.Generic;

    public class Coffee : ICoffee
    {
        public Coffee()
        {
            this.Cost = 1.50M;
            this.Ingredients.Add("coffee");
        }

        public decimal Cost { get; set; }
        public IList<string> Ingredients { get; set; } = new List<string>();
    }
}
