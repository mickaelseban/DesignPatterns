namespace DesignPatterns.Behavioral.Strategy.Hero
{
    using DesignPatterns.Behavioral.Strategy.SuperPowers;
    using DesignPatterns.Behavioral.Strategy.SuperPowers.Interface;

    public class SpiderMan : Hero
    {
        public SpiderMan(ISuperPower power) : base(power)
        {
        }

        public SpiderMan() : this(new WeaveWeb())
        {
        }
    }
}
