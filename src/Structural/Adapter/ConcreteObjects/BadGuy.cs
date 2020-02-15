namespace DesignPatterns.Structural.Adapter.ConcreteObjects
{
    using DesignPatterns.Structural.Adapter.ConcreteObjects.Interface;

    public class BadGuy : IBadGuy
    {
        public int Drive() => 2;

        public int Shoot() => 4;
    }
}
