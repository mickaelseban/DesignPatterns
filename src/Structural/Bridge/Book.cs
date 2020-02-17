namespace DesignPatterns.Structural.Bridge
{
    using DesignPatterns.Structural.Bridge.Formatters.Interface;
    using DesignPatterns.Structural.Bridge.Manuscripts;
    using System.Text;

    public class Book : Manuscript
    {
        public Book(IFormatter formatter, string title, string author, string text) : base(formatter)
        {
            Title = title;
            Author = author;
            Text = text;
        }

        public string Author { get; }
        public string Text { get; }
        public string Title { get; }

        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append(this._formatter.Format("Title", Title));
            sb.Append(this._formatter.Format("Author", Author));
            sb.Append(this._formatter.Format("Text", Text));
            return sb.ToString();
        }
    }
}
