namespace DesignPatterns.Behavioral.Memento
{
    public interface IDbCommand
    {
        void Execute(string text);

        void UnExecute();
    }
}
