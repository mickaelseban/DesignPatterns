namespace DesignPatterns.Behavioral.Memento
{
    public interface IDbCommand
    {
        void Execute(string input);

        void UnExecute();
    }
}
