namespace DesignPatterns.Behavioral.Memento
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer Clone() => MemberwiseClone() as Customer;
    }
}
