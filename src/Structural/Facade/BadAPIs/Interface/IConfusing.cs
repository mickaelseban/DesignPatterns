namespace DesignPatterns.Structural.Facade.BadAPIs.Interface
{
    public interface IConfusing
    {
        int Execute(int a, int b, int c);

        int Method1();

        int Method2(int x);

        int Method2(int x, int y);
    }
}
