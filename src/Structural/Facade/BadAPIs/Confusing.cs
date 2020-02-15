namespace DesignPatterns.Structural.Facade.BadAPIs
{
    using DesignPatterns.Structural.Facade.BadAPIs.Interface;

    public class Confusing : IConfusing
    {
        public int Execute(int a, int b, int c) => a + b + c;

        public int Method1() => 0;

        public int Method2(int x) => x;

        public int Method2(int x, int y) => x + y;
    }
}
