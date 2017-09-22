namespace Builder_0._01
{
    public class NiveaWomenBuilder:ShampooBuilder
    {
        public override void AddVitamins()
        {
            shampoo.Vitamins = "all the Mandaleev table";
        }

        public override void AddAroma()
        {
            shampoo.AromaType = AromaType.Rose;
        }

        public override void GenderMarket()
        {
            shampoo.GenderGroup = GenderGroup.women;
        }
    }
}