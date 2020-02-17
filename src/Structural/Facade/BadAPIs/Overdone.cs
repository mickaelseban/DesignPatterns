namespace DesignPatterns.Structural.Facade.BadAPIs
{
    using DesignPatterns.Structural.Facade.BadAPIs.Interface;

    public class Overdone : IOverdone
    {
        public Overdone(string someString)
        {
            this.SomeString = someString ?? string.Empty;
        }

        private string SomeString { get; }

        public int DoSomething(int a, int b) => a * b;

        public int DoSomethingAgain(int a, int b, int c, int d) => (a + b + c) * d;

        public int DoSomethingElse(int a, int b, int c) => (a + b) * c;
    }
}
