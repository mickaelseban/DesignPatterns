namespace DesignPatterns.Behavioral.Mediator
{
    using System.Text;

    public class NonSinger : Participant
    {
        public NonSinger(string name) : base(name)
        {
        }

        private string Description => "To a Non-Singer: ";

        public override string Receive(string from, string message)
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Description);
            sb.AppendLine(base.Receive(from, message));
            return sb.ToString();
        }
    }
}
