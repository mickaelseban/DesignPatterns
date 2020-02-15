namespace DesignPatterns.Creational.Tests.Factory.A_SimpleFactory
{
    using DesignPatterns.Creational.Factory.A_SimpleFactory;
    using DesignPatterns.Creational.Factory.Common.Pizza;
    using System;
    using System.Collections.Generic;
    using Xunit;

    [Collection("Creational.Tests")]
    public class SimplePizzaFactoryTest
    {
        [Theory]
        [InlineData(PizzaType.California)]
        public void ShouldDuplicateCodeAndReturnsNotNull(PizzaType pizzaType)
        {
            IPizza instance = null;
            IList<string> ingredients = null;

            switch (pizzaType)
            {
                case PizzaType.NewYork:
                    instance = new CaliforniaPizza(ingredients);
                    break;

                case PizzaType.Chicago:
                    instance = new ChicagoPizza(ingredients);
                    break;

                case PizzaType.California:
                    instance = new CaliforniaPizza(ingredients);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(pizzaType));
            }
            Assert.NotNull(instance as CaliforniaPizza);
        }
    }
}
