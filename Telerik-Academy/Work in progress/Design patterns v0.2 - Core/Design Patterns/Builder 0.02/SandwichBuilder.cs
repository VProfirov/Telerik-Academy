namespace Builder_0._02
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich CreateSandwich() => sandwich = new Sandwich();
//        public void CreateSandwich()
//        {
//            sandwich = new Sandwich();
//        }

        public Sandwich GetSandwich() => sandwich;

        //        public Sandwich GetSandwich()
        //        {
        //            return sandwich;
        //        }

        public abstract void AddingCheese();
        public abstract void AddingMeat();
        public abstract void AddingMustard();

    }
}