namespace DesignPatterns.Behavioral.Mediator
{
    public class Participant
    {
        public Participant(string name)
        {
            this.Name = name;
        }

        public ChatRoomMediator ChatRoomMediator { get; set; }

        public string Name { get; }

        public virtual string Receive(string from, string message)
        {
            return $"{from} to {this.Name}: '{message}'";
        }

        public void Send(string to, string message)
        {
            this.ChatRoomMediator.Send(this.Name, to, message);
        }
    }
}
