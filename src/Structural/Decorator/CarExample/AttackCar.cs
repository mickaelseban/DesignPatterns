namespace DesignPatterns.Structural.Decorator.CarExample
{
    public class AttackCar
    {
        private readonly ICar _decoratedCar;

        public AttackCar(ICar decoratedCar)
        {
            this._decoratedCar = decoratedCar;
        }

        public int Attack() => this._decoratedCar.Attack() + 150;

        public int Defend() => this._decoratedCar.Defend() - 20;

        public int Drive() => this._decoratedCar.Drive() - 20;
    }
}
