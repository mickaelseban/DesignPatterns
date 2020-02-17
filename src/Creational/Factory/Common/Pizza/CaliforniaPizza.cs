namespace DesignPatterns.Creational.Factory.Common.Pizza
{
    using System.Collections.Generic;

    public sealed class CaliforniaPizza : Pizza
    {
        public CaliforniaPizza(IList<string> ingredients) : base(ingredients)
        {
            this.Dough = DoughType.None;
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
