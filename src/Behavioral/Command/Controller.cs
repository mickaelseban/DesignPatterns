namespace DesignPatterns.Behavioral.Command
{
    using System.Collections.Generic;
    using System.Text;

    public class Controller
    {
        private readonly List<IAppCommand> _commands = new List<IAppCommand>();
        private readonly StringBuilder _stringBuilder = new StringBuilder();

        public int AddCommand(IAppCommand command)
        {
            command.Sb = this._stringBuilder;
            this._commands.Add(command);
            return this._commands.IndexOf(command);
        }

        public string GetBuiltString()
        {
            return this._stringBuilder.ToString();
        }

        public IAppCommand GetCommandAt(int x)
        {
            return this._commands[x];
        }

        public void RemoveCommand(int position)
        {
            this._commands.RemoveAt(position);
        }
    }
}
