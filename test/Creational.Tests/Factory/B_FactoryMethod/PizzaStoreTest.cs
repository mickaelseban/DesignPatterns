namespace DesignPatterns.Creational.Tests.Factory.B_FactoryMethod
{
    using DesignPatterns.Creational.Factory.B_FactoryMethod;
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System.Collections.Generic;
    using Xunit;

    [Collection("Creational.Tests")]
    public class PizzaStoreTest
    {
        [Theory]
        [InlineData(null)]
        public void ShouldCreatesASpecificInstance(IList<string> ingredients)
        {
            var sut = new NewYorkPizzaStore().OrderPizza(ingredients);

            Assert.NotNull(sut as NewYorkPizza);
        }
    }
}
