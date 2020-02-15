namespace DesignPatterns.Behavioral.Command
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class CommandBase : IAppCommand
    {
        protected readonly List<string> Entries = new List<string>();
        public StringBuilder Sb { get; set; }

        public abstract void Execute(string text);

        public abstract void UnExecute();
    }
}
