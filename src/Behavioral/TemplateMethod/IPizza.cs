namespace DesignPatterns.Behavioral.TemplateMethod
{
    using System.Collections.Generic;

    public interface IPizza
    {
        DoughTypeEnum Dough { get; }
        string SauceType { get; }
        string Seasonings { get; }
        IList<string> Toppings { get; }
    }
}
