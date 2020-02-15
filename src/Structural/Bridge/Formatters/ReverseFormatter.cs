namespace DesignPatterns.Structural.Bridge.Formatters
{
    using DesignPatterns.Structural.Bridge.Formatters.Interface;
    using System.Linq;

    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key} : {new string(value.Reverse().ToArray())}";
        }
    }
}
