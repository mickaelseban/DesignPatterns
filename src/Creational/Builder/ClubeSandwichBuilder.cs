namespace DesignPatterns.Creational.Builder
{
    using DesignPatterns.Creational.Builder.Model;
    using System.Collections.Generic;

    public class ClubeSandwichBuilder : SandwichBuilder
    {
        public override void AddCondiments()
        {
            Sandwich.HasMayo = true;
            Sandwich.HasMustard = false;
        }

        public override void ApllyMeatAndCheese()
        {
            Sandwich.CheeseType = CheeseType.Provolone;
            Sandwich.MeatType = MeatType.Salami;
        }

        public override void ApplyVegetables()
        {
            Sandwich.Vegetables = new List<string>
            {
                "Tomato",
                "Lettuce"
            };
        }

        public override void PrepareBread()
        {
            Sandwich.BreadType = BreadType.Wheat;
            Sandwich.IsToasted = true;
        }
    }
}
