namespace DesignPatterns.Creational.Builder.Model
{
    using System.Collections.Generic;

    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public CheeseType CheeseType { get; set; }
        public bool HasMayo { get; set; }
        public bool HasMustard { get; set; }
        public bool IsToasted { get; set; }
        public MeatType MeatType { get; set; }
        public List<string> Vegetables { get; set; }
    }
}
