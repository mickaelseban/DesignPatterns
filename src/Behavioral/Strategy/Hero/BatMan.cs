namespace DesignPatterns.Behavioral.Strategy.Hero
{
    using DesignPatterns.Behavioral.Strategy.SuperPowers.Interface;

    public class BatMan : Hero
    {
        public BatMan(ISuperPower power) : base(power)
        {
        }
    }
}
