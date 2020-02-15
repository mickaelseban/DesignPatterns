namespace DesignPatterns.Structural.Adapter.ConcreteObjects
{
    using DesignPatterns.Structural.Adapter.ConcreteObjects.Interface;

    public class FlyingSquirrel : IFlyingSquirrel
    {
        public int DropAcorns() => 7;

        public int Fly() => 5;
    }
}
