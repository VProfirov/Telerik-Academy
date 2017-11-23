namespace Infestation
{
    public class AggressionCatalyst:ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException("AggressionCatalyst is can't ReacTo(ISupplement)");
        }

        public int PowerEffect { get; } = 0;
        public int HealthEffect { get; } = 0;
        public int AggressionEffect { get; } = 3;
    }
}