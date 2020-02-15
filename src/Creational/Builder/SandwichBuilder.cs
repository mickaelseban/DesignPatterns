namespace DesignPatterns.Creational.Builder
{
    using DesignPatterns.Creational.Builder.Model;

    public abstract class SandwichBuilder
    {
        protected Sandwich Sandwich;

        public abstract void AddCondiments();

        public abstract void ApllyMeatAndCheese();

        public abstract void ApplyVegetables();

        public void CreateNewSandwich()
        {
            this.Sandwich = new Sandwich();
        }

        public Sandwich GetSandwich()
        {
            return this.Sandwich;
        }

        public abstract void PrepareBread();
    }
}
