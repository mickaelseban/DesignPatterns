namespace DesignPatterns.Behavioral.Tests.Mediator
{
    using DesignPatterns.Behavioral.Mediator;
    using Xunit;

    [Collection("Behavioral.Tests")]
    public class ChatroomMediatorTest
    {
        [Fact]
        public void ChatroomMediatorShouldReturn()
        {
            // Arrange
            ChatroomMediator sut = new ChatroomMediator();

            Singer john = new Singer("john");
            Singer mike = new Singer("mike");
            Singer douglas = new Singer("douglas");

            NonSinger james = new NonSinger("james");
            NonSinger carl = new NonSinger("carl");
            NonSinger frankie = new NonSinger("frankie");

            sut.Register(john);
            sut.Register(mike);
            sut.Register(douglas);
            sut.Register(james);
            sut.Register(carl);
            sut.Register(frankie);

            // Act
            mike.Send("john", "test");
            string actual = sut.Messages?.Peek();

            // Assert
            Assert.NotNull(sut);
            Assert.NotNull(actual);
            Assert.Contains("john", actual);
        }
    }
}
