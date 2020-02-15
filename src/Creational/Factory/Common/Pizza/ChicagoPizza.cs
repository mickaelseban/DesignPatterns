namespace DesignPatterns.Creational.Factory.Common.Pizza
{
    using System.Collections.Generic;

    public sealed class ChicagoPizza : Pizza
    {
        public ChicagoPizza(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Pan;
        }

        public override void Bake()
        {
            //throw new NotImplementedException();
        }

        public override void Box()
        {
            //throw new NotImplementedException();
        }

        public override void Cut()
        {
            //throw new NotImplementedException();
        }
    }
}
