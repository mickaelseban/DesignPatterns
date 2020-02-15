namespace DesignPatterns.Creational.Tests.Factory.C_AbstractFactory
{
    using DesignPatterns.Creational.Factory.C_AbstractFactory;
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;
    using Xunit;

    [Collection("Creational.Tests")]
    public class PizzaStoreWithAbstractFactoryTest
    {
        [Theory]
        [InlineData(null)]
        public void ShouldCreatesASpecificInstanceWithAbstractFactory(IList<string> ingredients)
        {
            IPizza sut = null;
            sut = new NewYorkPizzaStoreWithAbstractFactory(new NewYorkPizzaFactory()).OrderPizza(ingredients);
            Assert.NotNull(sut as NewYorkPizza);
        }

        [Fact]
        public void ShouldNotCreatesAChicagoPizzaWithAbstractFactory()
        {
            IPizza sut = null;
            IList<string> ingredients = null;
            sut = new ChicagoPizzaStoreWithAbstractFactory(new NewYorkPizzaFactory()).OrderPizza(ingredients);
            Assert.Null(sut as ChicagoPizza);
        }
    }
}
