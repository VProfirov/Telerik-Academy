namespace Infestation
{
    public class HealthCatalyst:ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException("HealthCatalyst is can't ReacTo(ISupplement)");
        }

        public int PowerEffect { get; } = 0;
        public int HealthEffect { get; } = 3;
        public int AggressionEffect { get; } = 0;
    }
}