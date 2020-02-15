namespace DesignPatterns.Structural.Decorator.CarExample
{
    public class ArmoredCar : ICar
    {
        private readonly ICar _decoratedCar;

        public ArmoredCar(ICar decoratedCar)
        {
            this._decoratedCar = decoratedCar;
        }

        public int Attack() => this._decoratedCar.Attack() - 10;

        public int Defend() => this._decoratedCar.Defend() + 150;

        public int Drive() => this._decoratedCar.Drive() - 50;
    }
}
