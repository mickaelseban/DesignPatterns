namespace DesignPatterns.Behavioral.Tests.Memento
{
    using DesignPatterns.Behavioral.Memento;
    using Xunit;

    [Collection("Behavioral.Tests")]
    public class CustomerMementoTest
    {
        [Fact]
        public void Should_RollBack_Customer_Entity()
        {
            var originalName = "John Doe";
            var cust = new Customer { Id = 5, Name = originalName };
            var cmd = new ChangeCustomerCommand(cust);
            var newName = "Billy Bob";
            cmd.Execute(newName);
            cmd.UnExecute();
            Assert.Equal(originalName, cmd.Customer.Name);
            Assert.Equal(5, cmd.Customer.Id);
        }

        [Fact]
        public void Should_Update_The_Customer_Name()
        {
            var entity = new Customer { Id = 1, Name = "Mickael Seban" };
            var command = new ChangeCustomerCommand(entity);
            const string newName = "John Dee";
            command.Execute(newName);
            Assert.Equal(newName, command.Customer.Name);
        }
    }
}
