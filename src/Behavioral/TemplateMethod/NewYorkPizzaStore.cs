namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class NewYorkPizzaStore : PizzaStoreBase
    {
        public override void Cook()
        {
            //cook the thin crust pizza in a wood fired oven
            //operates on PizzaForDelivery
        }

        public override void Make()
        {
            //add thin crust dough and NY style specific ingredients
            //operates on PizzaForDelivery
        }

        public override void TakeOrder()
        {
            //great places for a call to the basic factory pattern
            //operates on PizzaForDelivery
        }
    }
}
