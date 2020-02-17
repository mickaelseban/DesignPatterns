namespace DesignPatterns.Structural.Bridge.Manuscripts
{
    using DesignPatterns.Structural.Bridge.Formatters.Interface;

    public abstract class Manuscript
    {
        protected readonly IFormatter _formatter;

        protected Manuscript(IFormatter formatter)
        {
            this._formatter = formatter;
        }

        public abstract string Print();
    }
}
