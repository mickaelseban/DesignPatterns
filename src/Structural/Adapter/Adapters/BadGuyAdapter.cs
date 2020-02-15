namespace DesignPatterns.Structural.Adapter.Adapters
{
    using DesignPatterns.Structural.Adapter.Adapters.Interface;
    using DesignPatterns.Structural.Adapter.ConcreteObjects.Interface;

    public class BadGuyAdapter : ICharacter
    {
        private readonly IBadGuy _badGuy;

        public BadGuyAdapter(IBadGuy badGuy)
        {
            _badGuy = badGuy;
        }

        public int Attack() => _badGuy.Shoot();

        public int Chase() => _badGuy.Shoot();

        public int Flee() => _badGuy.Drive();
    }
}
