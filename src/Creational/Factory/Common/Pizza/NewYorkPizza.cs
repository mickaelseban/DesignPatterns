namespace DesignPatterns.Creational.Factory.Common.Pizza
{
    using System.Collections.Generic;

    public sealed class NewYorkPizza : Pizza
    {
        public NewYorkPizza(IList<string> ingredients)
            : base(ingredients)
        {
            this.Dough = DoughType.Thin;
        }

        public override void Bake()
        {
        }

        public override void Box()
        {
        }

        public override void Cut()
        {
        }
    }
}
