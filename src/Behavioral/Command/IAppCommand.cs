namespace DesignPatterns.Behavioral.Command
{
    using System.Text;

    public interface IAppCommand
    {
        StringBuilder Sb { get; set; }

        void Execute(string value);

        void UnExecute();
    }
}
