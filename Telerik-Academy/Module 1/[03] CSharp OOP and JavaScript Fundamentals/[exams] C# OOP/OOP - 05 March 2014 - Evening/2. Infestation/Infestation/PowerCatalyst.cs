namespace Infestation
{
    public class PowerCatalyst:ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException("PowerCatalyst is can't ReacTo(ISupplement)");
        }

        public int PowerEffect { get; } = 3;
        public int HealthEffect { get; } = 0;
        public int AggressionEffect { get; } = 0;
    }
}