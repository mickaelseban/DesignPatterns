namespace DesignPatterns.Structural.Decorator.CarExample
{
    public class CarBase : ICar
    {
        public int Attack() => 100;

        public int Defend() => 100;

        public int Drive() => 100;
    }
}
