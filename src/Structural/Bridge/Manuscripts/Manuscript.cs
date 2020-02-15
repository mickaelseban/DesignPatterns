namespace DesignPatterns.Structural.Bridge.Manuscripts
{
    using DesignPatterns.Structural.Bridge.Formatters.Interface;

    public abstract class Manuscript
    {
        protected readonly IFormatter formatter;

        public Manuscript(IFormatter formatter)
        {
            this.formatter = formatter;
        }

        public abstract string Print();
    }
}
