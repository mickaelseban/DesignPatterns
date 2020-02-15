namespace DesignPatterns.Behavioral.Strategy.Hero
{
    using DesignPatterns.Behavioral.Strategy.Hero.Interface;
    using DesignPatterns.Behavioral.Strategy.SuperPowers.Interface;

    public class Hero : IHero
    {
        private ISuperPower _power;

        public Hero(ISuperPower power)
        {
            _power = power;
        }

        public void ChangeSuperPower(ISuperPower power)
        {
            _power = power;
        }

        public string DoHeroStuff() => _power.ExercisePower();
    }
}
