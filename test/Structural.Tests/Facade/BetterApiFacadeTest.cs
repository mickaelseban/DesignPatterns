namespace DesignPatterns.Structural.Tests.Facade
{
    using DesignPatterns.Structural.Facade.BadAPIs;
    using DesignPatterns.Structural.Facade.BetterAPI;
    using DesignPatterns.Structural.Facade.BetterAPI.Interface;
    using Xunit;

    [Collection("Structural.Tests")]
    public class BetterApiFacadeTest
    {
        [Fact]
        public void ShouldCallBetterApiFacade()
        {
            IBetterApiFacade sut = new BetterApiFacade(new Overdone("foo"), new Confusing());
            Assert.Equal(6, sut.AddThreeNumbers(1, 2, 3));
            Assert.Equal(20, sut.AddThenMultiply(4, 5));
            Assert.Equal(35, sut.AddThenMultiply(4, 3, 5));
            Assert.Equal(45, sut.AddThenMultiply(4, 3, 2, 5));
        }
    }
}
