namespace DesignPatterns.Structural.Decorator.CarExample
{
    public class RaceCar : ICar
    {
        private readonly ICar _decoratedCar;

        public RaceCar(ICar decoratedCar)
        {
            this._decoratedCar = decoratedCar;
        }

        public int Attack() => this._decoratedCar.Attack() - 50;

        public int Defend() => this._decoratedCar.Defend() - 20;

        public int Drive() => this._decoratedCar.Drive() + 200;
    }
}
