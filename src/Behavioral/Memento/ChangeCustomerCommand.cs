namespace DesignPatterns.Behavioral.Memento
{
    using System.Collections.Generic;

    public class ChangeCustomerCommand : IDbCommand
    {
        private readonly List<MementoForCustomerEntity> _mementos = new List<MementoForCustomerEntity>();

        public ChangeCustomerCommand(Customer customer)
        {
            this.Customer = customer;
        }

        public Customer Customer { get; private set; }

        public void Execute(string input)
        {
            this._mementos.Add(new MementoForCustomerEntity(this.Customer));
            this.Customer.Name = input;
        }

        public void UnExecute()
        {
            this.Customer = (this._mementos[this._mementos.Count - 1].GetCustomer());
            this._mementos.RemoveAt(this._mementos.Count - 1);
        }
    }
}
