using System.Collections.Generic;

namespace Builder
{
    public class MySandwichBuilder:SandwichBuilder
    {
        // it is all abstracted
//        private Sandwich sandwich;

        //-> abstract it
//        public Sandwich GetSandwich()
//        {
//            return sandwich;
//        }

//        //->abstract it as a common interface
//        public void CreateSandwich()
//        {
//            //Steps(methods) of creation - abstract that so you have different ways of creating a different sandwiches
//                  //SandwichMaker
//            sandwich = new Sandwich();
//            PrepareBread();
//            ApplyMeatAndCheese();
//            ApplyVegetables();
//            AddCondiments();
//        }

        public override void AddCondiments()
        {
            // for each part of the cration process we need - this step allows us this separation and abstraction
            //maybe validation ; maybe checking ; decision making
            sandwich.HasMayo = false;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.french;
            sandwich.MeatType = MeatType.chicken;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.dark;
            sandwich.IsToasted = true;
        }
    }
}