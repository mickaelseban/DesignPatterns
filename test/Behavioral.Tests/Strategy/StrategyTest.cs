namespace DesignPatterns.Behavioral.Tests.Strategy
{
    using DesignPatterns.Behavioral.Strategy.Hero;
    using DesignPatterns.Behavioral.Strategy.Hero.Interface;
    using DesignPatterns.Behavioral.Strategy.SuperPowers;
    using DesignPatterns.Behavioral.Strategy.SuperPowers.Interface;
    using Xunit;

    [Collection("Behavioral.Tests")]
    public class StrategyTest
    {
        [Fact]
        public void Should_Return_Super_Power()
        {
            IHero spiderMan = new SpiderMan(new WeaveWeb());
            string expected = new WeaveWeb().ExercisePower();
            Assert.Equal(expected, spiderMan.DoHeroStuff());
        }

        [Fact]
        public void Should_Returns_Changed_Super_Power()
        {
            IHero spiderMan = new SpiderMan(new WeaveWeb());
            Assert.Equal(new WeaveWeb().ExercisePower(), spiderMan.DoHeroStuff());
            ISuperPower newSuperPower = new Fly();
            spiderMan.ChangeSuperPower(newSuperPower);
            Assert.Equal(newSuperPower.ExercisePower(), spiderMan.DoHeroStuff());
        }
    }
}
