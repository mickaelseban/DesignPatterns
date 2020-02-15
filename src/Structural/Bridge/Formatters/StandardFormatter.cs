namespace DesignPatterns.Structural.Bridge.Formatters
{
    using DesignPatterns.Structural.Bridge.Formatters.Interface;

    public class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key} : {value}";
        }
    }
}
