namespace DesignPatterns.Behavioral.Mediator
{
    using System.Collections.Generic;

    public class ChatRoomMediator
    {
        public readonly Queue<string> Messages = new Queue<string>(5);
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (!this._participants.ContainsValue(participant))
            {
                this._participants[participant.Name] = participant;
            }
            participant.ChatRoomMediator = this;
        }

        public void Send(string from, string to, string message)
        {
            var participant = this._participants[to];
            var messageSent = participant?.Receive(@from, message);
            this.Messages.Enqueue(new string(messageSent?.ToCharArray()));
        }
    }
}
