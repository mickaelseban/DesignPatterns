namespace DesignPatterns.Structural.Composite
{
    using System.Collections.Generic;

    public class GroupEmail : ISendEmail
    {
        private readonly IEnumerable<ISendEmail> _sendEmailsImplementations;

        public GroupEmail(string name, IEnumerable<ISendEmail> sendEmailsImplementations)
        {
            this._sendEmailsImplementations = sendEmailsImplementations;
            this.Name = name;
        }

        public string Name { get; private set; }

        public void SendEmail()
        {
            foreach (ISendEmail sendEmailImplementation in this._sendEmailsImplementations)
            {
                sendEmailImplementation.SendEmail();
            }
        }
    }
}
