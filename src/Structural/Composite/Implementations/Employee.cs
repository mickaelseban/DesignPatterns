namespace DesignPatterns.Structural.Composite.Implementations
{
    public class Employee
    {
        public Employee(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public string Email { get; private set; }
        public string Name { get; private set; }
    }
}
