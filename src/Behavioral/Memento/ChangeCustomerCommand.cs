namespace DesignPatterns.Behavioral.Memento
{
    using System.Collections.Generic;

    public class ChangeCustomerCommand : IDbCommand
    {
        private readonly List<MementoForCustomerEntity> _mementos = new List<MementoForCustomerEntity>();

        public ChangeCustomerCommand(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; private set; }

        public void Execute(string newName)
        {
            _mementos.Add(new MementoForCustomerEntity(Customer));
            Customer.Name = newName;
        }

        public void UnExecute()
        {
            Customer = (_mementos[_mementos.Count - 1].GetCustomer());
            _mementos.RemoveAt(_mementos.Count - 1);
        }
    }
}
