namespace DesignPatterns.Behavioral.Mediator
{
    public interface IParticipant
    {
        string Name { get; }

        string Receive(string from, string message);

        void Send(string to, string message);
    }
}
