namespace DesignPatterns.Structural.Facade.BetterAPI
{
    using DesignPatterns.Structural.Facade.BadAPIs.Interface;
    using DesignPatterns.Structural.Facade.BetterAPI.Interface;

    public class BetterApiFacade : IBetterApiFacade
    {
        private readonly IConfusing _confusing;
        private readonly IOverdone _overdone;

        public BetterApiFacade(IOverdone overdone, IConfusing confusing)
        {
            _overdone = overdone;
            _confusing = confusing;
        }

        // public BetterApiFacade() : this(new Overdone("foo"), new Confusing()) { }

        int IBetterApiFacade.AddThenMultiply(int addend1, int factor)
            => _overdone.DoSomething(addend1, factor);

        int IBetterApiFacade.AddThenMultiply(int addend1, int addend2, int factor)
            => _overdone.DoSomethingElse(addend1, addend2, factor);

        int IBetterApiFacade.AddThenMultiply(int addend1, int addend2, int addend3, int factor)
            => _overdone.DoSomethingAgain(addend1, addend2, addend3, factor);

        int IBetterApiFacade.AddThreeNumbers(int firstParam, int secondParam, int thirdParam)
                                    => _confusing.Execute(firstParam, secondParam, thirdParam);
    }
}
