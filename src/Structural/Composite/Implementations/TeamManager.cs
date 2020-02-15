namespace DesignPatterns.Structural.Composite.Implementations
{
    using System;

    public class TeamManager : Employee, ISendEmail
    {
        public TeamManager(string name, string email) : base(name, email)
        {
        }

        public void SendEmail()
        {
            Console.WriteLine($"Send email to {this.Email}");
        }
    }
}
