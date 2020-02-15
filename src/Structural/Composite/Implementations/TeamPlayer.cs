namespace DesignPatterns.Structural.Composite.Implementations
{
    using System;

    public class TeamPlayer : Employee, ISendEmail
    {
        public TeamPlayer(string name, string email) : base(name, email)
        {
        }

        public void SendEmail()
        {
            Console.WriteLine($"Send email to {this.Email}");
        }
    }
}
