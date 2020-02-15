namespace DesignPatterns.Creational.Factory.Common.Pizza
{
    using System.Collections.Generic;

    public sealed class NewYorkPizza : Pizza
    {
        public NewYorkPizza(IList<string> ingredients) : base(ingredients)
        {
            Dough = DoughType.Thin;
        }

        public override void Bake()
        {
            //throw new System.NotImplementedException();
        }

        public override void Box()
        {
            //throw new System.NotImplementedException();
        }

        public override void Cut()
        {
            //throw new System.NotImplementedException();
        }
    }
}
