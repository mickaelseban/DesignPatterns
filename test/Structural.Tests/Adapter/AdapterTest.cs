namespace DesignPatterns.Structural.Tests.Adapter
{
    using DesignPatterns.Structural.Adapter.Adapters;
    using DesignPatterns.Structural.Adapter.Adapters.Interface;
    using DesignPatterns.Structural.Adapter.ConcreteObjects;
    using Xunit;

    [Collection("Structural.Tests")]
    public class AdapterTest
    {
        [Theory]
        [InlineData(4, 4, 2)]
        public void ShouldReturnsACharacterFromBadGuy(int attack, int chase, int flee)
        {
            ICharacter character = new BadGuyAdapter(new BadGuy());
            Assert.Equal(attack, character.Attack());
            Assert.Equal(chase, character.Chase());
            Assert.Equal(flee, character.Flee());
        }

        [Theory]
        [InlineData(7, 7, 5)]
        public void ShouldReturnsACharacterFromFlyingSquirrel(int attack, int chase, int flee)
        {
            ICharacter character = new FlyingSquirrelAdapter(new FlyingSquirrel());
            Assert.Equal(attack, character.Attack());
            Assert.Equal(chase, character.Chase());
            Assert.Equal(flee, character.Flee());
        }

        [Theory]
        [InlineData(1, 9, 9)]
        public void ShouldReturnsACharacterFromMoose(int attack, int chase, int flee)
        {
            ICharacter character = new MooseAdapter(new Moose());
            Assert.Equal(attack, character.Attack());
            Assert.Equal(chase, character.Chase());
            Assert.Equal(flee, character.Flee());
        }
    }
}
