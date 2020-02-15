namespace DesignPatterns.Structural.Decorator.CoffeeExample
{
    using System.Collections.Generic;
    using System.Linq;

    public class ExpressoCoffee : ICoffee
    {
        private readonly ICoffee _coffeeDecorated;

        public ExpressoCoffee(ICoffee coffeeDecorated)
        {
            this._coffeeDecorated = coffeeDecorated;
            this.Cost = this._coffeeDecorated.Cost + 10;
            this.Ingredients = this._coffeeDecorated.Ingredients.Select(x => x)?.ToList();
            this.Ingredients.Add("foo");
        }

        /// <summary>
        /// Faking Di with concret class
        /// </summary>
        public ExpressoCoffee() : this(new Coffee()) { }

        public decimal Cost { get; set; }
        public IList<string> Ingredients { get; set; } = new List<string>();
    }
}
