namespace DesignPatterns.Behavioral.Mediator
{
    using System.Collections.Generic;

    public class ChatroomMediator
    {
        public readonly Queue<string> Messages = new Queue<string>(5);
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
            {
                _participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            Participant participant = _participants[to];
            string messageSent = participant?.Receive(@from, message);
            Messages.Enqueue(new string(messageSent?.ToCharArray()));
        }
    }
}
