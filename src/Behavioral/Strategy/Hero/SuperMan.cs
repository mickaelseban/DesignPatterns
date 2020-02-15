namespace DesignPatterns.Behavioral.Strategy.Hero
{
    using DesignPatterns.Behavioral.Strategy.SuperPowers.Interface;

    public class SuperMan : Hero
    {
        public SuperMan(ISuperPower power) : base(power)
        {
        }
    }
}
