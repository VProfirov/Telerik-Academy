namespace Builder
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        // abstract the processes(the different ways) of making the different sandwiches
        public void CreateSandwich()
        {
            sandwich = new Sandwich();
        }

        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public abstract void AddCondiments();
    }
}