namespace DesignPatterns.Behavioral.TemplateMethod
{
    using System.Collections.Generic;

    public class ThinCrustPizza : IPizza
    {
        public DoughType Dough => DoughType.Thin;
        public string SauceType => string.Empty;
        public string Seasonings => string.Empty;
        public IList<string> Toppings => new List<string>();
    }
}
