namespace DesignPatterns.Behavioral.Command
{
    public class AddTextCommand : CommandBase
    {
        public override void Execute(string value)
        {
            base.Sb.Append(value);
            base.Entries.Add(value);
        }

        public override void UnExecute()
        {
            var entryLength = base.Entries[base.Entries.Count - 1].Length;
            var totalLength = base.Sb.Length;
            base.Sb.Remove(totalLength - entryLength, entryLength);
            base.Entries.RemoveAt(base.Entries.Count - 1);
        }
    }
}
