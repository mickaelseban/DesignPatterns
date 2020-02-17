namespace DesignPatterns.Structural.Decorator.CoffeeExample
{
    using System.Collections.Generic;
    using System.Linq;

    public class ExpressoCoffee : ICoffee
    {
        public ExpressoCoffee(ICoffee coffeeDecorated)
        {
            this.Cost = coffeeDecorated.Cost + 10;
            this.Ingredients = coffeeDecorated.Ingredients.Select(x => x)?.ToList();
            this.Ingredients.Add("foo");
        }

        public decimal Cost { get; set; }
        public IList<string> Ingredients { get; set; }
    }
}
