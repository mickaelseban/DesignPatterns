namespace DesignPatterns.Structural.Adapter.ConcreteObjects
{
    using DesignPatterns.Structural.Adapter.ConcreteObjects.Interface;

    public class Moose : IMoose
    {
        public int Charge() => 1;

        public int Run() => 9;
    }
}
