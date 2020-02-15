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
