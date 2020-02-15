namespace DesignPatterns.Structural.Decorator.CoffeeExample
{
    using System.Collections.Generic;

    public interface ICoffee
    {
        decimal Cost { get; set; }

        IList<string> Ingredients { get; set; }
    }
}
