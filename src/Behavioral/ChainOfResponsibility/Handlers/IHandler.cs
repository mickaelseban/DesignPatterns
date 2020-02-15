namespace DesignPatterns.Behavioral.ChainOfResponsibility.Handlers
{
    public interface IHandler
    {
        Response Handle(MobileType request);

        IHandler SetNext(IHandler handler);
    }
}
