namespace DesignPatterns.Behavioral.TemplateMethod
{
    public abstract class PizzaStoreBase
    {
        protected IPizza PizzaForDelivery;

        public abstract void Cook();

        public IPizza CreatePizzaForDelivery()
        {
            TakeOrder();
            ProcessPayment();
            Make();
            Cook();
            return PizzaForDelivery;
        }

        public abstract void Make();

        public abstract void TakeOrder();

        internal void Delivery()
        {
            // needs implementation
        }

        internal void ProcessPayment()
        {
            // needs implementation
        }
    }
}
