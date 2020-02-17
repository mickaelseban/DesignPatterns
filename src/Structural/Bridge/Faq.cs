namespace DesignPatterns.Structural.Bridge
{
    using DesignPatterns.Structural.Bridge.Formatters.Interface;
    using DesignPatterns.Structural.Bridge.Manuscripts;
    using System.Collections.Generic;
    using System.Text;

    public class Faq : Manuscript
    {
        public Faq(IFormatter formatter, string title, Dictionary<string, string> questions) : base(formatter)
        {
            Title = title;
            Questions = questions;
        }

        public Dictionary<string, string> Questions { get; }

        public string Title { get; }

        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(this._formatter.Format("Title", Title));
            foreach (var question in Questions)
            {
                sb.Append(this._formatter.Format("   Question", question.Key));
                sb.Append(this._formatter.Format("   Answer", question.Value));
            }
            return sb.ToString();
        }
    }
}
