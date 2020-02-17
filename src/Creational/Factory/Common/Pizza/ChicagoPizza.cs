namespace DesignPatterns.Creational.Factory.Common.Pizza
{
    using System.Collections.Generic;

    public sealed class ChicagoPizza : Pizza
    {
        public ChicagoPizza(IList<string> ingredients) :
            base(ingredients)
        {
            this.Dough = DoughType.Pan;
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
