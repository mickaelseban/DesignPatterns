namespace DesignPatterns.Behavioral.Mediator
{
    public class Participant
    {
        private readonly string _name;
        private ChatroomMediator _chatroomMediator;

        public Participant(string name)
        {
            this._name = name;
        }

        public ChatroomMediator Chatroom
        {
            set => _chatroomMediator = value;
            get => _chatroomMediator;
        }

        public string Name => _name;

        public virtual string Receive(string from, string message)
        {
            return $"{from} to {Name}: '{message}'";
        }

        public void Send(string to, string message)
        {
            _chatroomMediator.Send(_name, to, message);
        }
    }
}
