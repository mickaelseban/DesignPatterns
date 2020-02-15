namespace DesignPatterns.Structural.Tests.Decorator.CarExample
{
    using DesignPatterns.Structural.Decorator.CarExample;
    using Xunit;

    [Collection("Structural.Tests")]
    public class ArmoredCarTest
    {
        [Fact]
        public void Should_Returns_a_Decorated_ArmoredCar()
        {
            ICar sut = new ArmoredCar(new CarBase());
            Assert.NotNull(sut);
        }

        [Theory]
        [InlineData(90, 250, 50)]
        public void Should_Returns_a_Decorated_ArmoredCar_With_Correct_Values(int attack, int defend, int drive)
        {
            ICar sut = new ArmoredCar(new CarBase());
            Assert.Equal(sut.Attack(), attack);
            Assert.Equal(sut.Defend(), defend);
            Assert.Equal(sut.Drive(), drive);
        }
    }
}
