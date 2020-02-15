namespace DesignPatterns.Creational.Builder
{
    using DesignPatterns.Creational.Builder.Model;
    using System.Collections.Generic;

    public class MySandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            Sandwich.HasMayo = false;
            Sandwich.HasMustard = true;
        }

        public override void ApllyMeatAndCheese()
        {
            Sandwich.CheeseType = CheeseType.Cheddar;
            Sandwich.MeatType = MeatType.Turkey;
        }

        public override void ApplyVegetables()
        {
            Sandwich.Vegetables = new List<string>
            {
                "Tomato",
                "Onion"
            };
        }

        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.White;
            Sandwich.IsToasted = true;
        }
    }
}
