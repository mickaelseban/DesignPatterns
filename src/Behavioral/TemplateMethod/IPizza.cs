namespace DesignPatterns.Behavioral.TemplateMethod
{
    using System.Collections.Generic;

    public interface IPizza
    {
        DoughType Dough { get; }
        string SauceType { get; }
        string Seasonings { get; }
        IList<string> Toppings { get; }
    }
}
