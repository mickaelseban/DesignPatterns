namespace DesignPatterns.Structural.Adapter.Adapters
{
    using DesignPatterns.Structural.Adapter.Adapters.Interface;
    using DesignPatterns.Structural.Adapter.ConcreteObjects.Interface;

    public class MooseAdapter : ICharacter
    {
        private readonly IMoose _moose;

        public MooseAdapter(IMoose moose)
        {
            _moose = moose;
        }

        public int Attack() => _moose.Charge();

        public int Chase() => _moose.Run();

        public int Flee() => _moose.Run();
    }
}
