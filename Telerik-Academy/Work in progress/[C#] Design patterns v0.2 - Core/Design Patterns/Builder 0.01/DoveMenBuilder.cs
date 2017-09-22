namespace Builder_0._01
{
    public class DoveMenBuilder:ShampooBuilder
    {
        public override void AddVitamins()
        {
            shampoo.Vitamins = "B6 and DHEA";
        }

        public override void AddAroma()
        {
            shampoo.AromaType = AromaType.Citron;
        }

        public override void GenderMarket()
        {
            shampoo.GenderGroup = GenderGroup.men;
        }
    }
}