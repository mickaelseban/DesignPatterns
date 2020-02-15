namespace DesignPatterns.Behavioral.TemplateMethod
{
    using System.Collections.Generic;

    public class ThinCrustPizza : IPizza
    {
        public DoughTypeEnum Dough => DoughTypeEnum.Thin;
        public string SauceType => string.Empty;
        public string Seasonings => string.Empty;
        public IList<string> Toppings => null;
    }
}
