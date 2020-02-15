namespace DesignPatterns.Behavioral.Memento
{
    public class MementoForCustomerEntity
    {
        private Customer _customer;

        public MementoForCustomerEntity(Customer customer)
        {
            _customer = customer.Clone();
        }

        public Customer GetCustomer() => _customer;
    }
}
