namespace DesignPatterns.Behavioral.Strategy.Hero.Interface
{
    using DesignPatterns.Behavioral.Strategy.SuperPowers.Interface;

    public interface IHero
    {
        void ChangeSuperPower(ISuperPower power);

        string DoHeroStuff();
    }
}
