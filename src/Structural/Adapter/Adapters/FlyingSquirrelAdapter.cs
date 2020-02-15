namespace DesignPatterns.Structural.Adapter.Adapters
{
    using DesignPatterns.Structural.Adapter.Adapters.Interface;
    using DesignPatterns.Structural.Adapter.ConcreteObjects.Interface;

    public class FlyingSquirrelAdapter : ICharacter
    {
        private readonly IFlyingSquirrel _flyingSquirrel;

        public FlyingSquirrelAdapter(IFlyingSquirrel flyingSquirrel)
        {
            _flyingSquirrel = flyingSquirrel;
        }

        public int Attack() => _flyingSquirrel.DropAcorns();

        public int Chase() => _flyingSquirrel.DropAcorns();

        public int Flee() => _flyingSquirrel.Fly();
    }
}
