namespace DesignPatterns.Creational.Tests.Builder
{
    using DesignPatterns.Creational.Builder;
    using DesignPatterns.Creational.Builder.Model;
    using FluentAssertions;
    using System.Collections.Generic;
    using Xunit;

    [Collection("Creational.Tests")]
    public class SandwichBuilderTest
    {
        [Fact]
        public void MySandwichBuilderShouldReturnSandwich()
        {
            // ARRANGE
            var sut = new SandwichMaker(new MySandwichBuilder());
            var expected = new Sandwich
            {
                HasMayo = false,
                HasMustard = true,
                CheeseType = CheeseType.Cheddar,
                MeatType = MeatType.Turkey,
                Vegetables = new List<string>
                {
                    "Tomato",
                    "Onion"
                },
                BreadType = BreadType.White,
                IsToasted = true
            };

            // ACT
            sut.BuildSandwich();
            var actual = sut.GetSandwich();

            // ASSERT
            expected.Should().BeEquivalentTo(actual);
        }
    }
}
