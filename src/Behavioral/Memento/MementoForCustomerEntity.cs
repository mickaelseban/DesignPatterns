namespace DesignPatterns.Behavioral.Memento
{
    public class MementoForCustomerEntity
    {
        private readonly Customer _customer;

        public MementoForCustomerEntity(Customer customer)
        {
            this._customer = customer.Clone();
        }

        public Customer GetCustomer() => this._customer;
    }
}
