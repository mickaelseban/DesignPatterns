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
            this._overdone = overdone;
            this._confusing = confusing;
        }

        int IBetterApiFacade.AddThenMultiply(int addend1, int factor)
        {
            return this._overdone.DoSomething(addend1, factor);
        }

        int IBetterApiFacade.AddThenMultiply(int addend1, int addend2, int factor)
        {
            return this._overdone.DoSomethingElse(addend1, addend2, factor);
        }

        int IBetterApiFacade.AddThenMultiply(int addend1, int addend2, int addend3, int factor)
        {
            return this._overdone.DoSomethingAgain(addend1, addend2, addend3, factor);
        }

        int IBetterApiFacade.AddThreeNumbers(int firstParam, int secondParam, int thirdParam)
        {
            return this._confusing.Execute(firstParam, secondParam, thirdParam);
        }
    }
}
