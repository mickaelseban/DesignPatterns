namespace DesignPatterns.Behavioral.Tests.Command
{
    using DesignPatterns.Behavioral.Command;
    using Xunit;

    public class AddNumberCommandTest
    {
        [Fact]
        public void Should_Add_Number_As_Text()
        {
            var controller = new Controller();
            IAppCommand addNumbersCommand = new AddNumbersCommand();
            var addCommandReference = controller.AddCommand(addNumbersCommand);
            var expected = "1234";
            controller.GetCommandAt(addCommandReference).Execute(expected);
            Assert.Equal(expected, controller.GetBuiltString());
        }

        [Fact]
        public void Should_Undo_Number_As_Text()
        {
            var controller = new Controller();
            IAppCommand addNumbersCommand = new AddNumbersCommand();
            var addCommandReference = controller.AddCommand(addNumbersCommand);
            var expected = "1234";
            controller.GetCommandAt(addCommandReference).Execute(expected);
            controller.GetCommandAt(addCommandReference).Execute("5678");
            controller.GetCommandAt(addCommandReference).UnExecute();
            Assert.Equal(expected, controller.GetBuiltString());
        }
    }
}
