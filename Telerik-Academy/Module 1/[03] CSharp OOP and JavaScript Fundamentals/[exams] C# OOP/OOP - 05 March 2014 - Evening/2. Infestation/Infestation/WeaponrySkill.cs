namespace Infestation
{
    public class WeaponrySkill:ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
            throw new System.NotImplementedException("Unconfirmed need of implementing WeaponrySkill to ReactTo(ISupplement) - probably not");
        }

        public int PowerEffect { get; } = 0;
        public int HealthEffect { get; } = 0;
        public int AggressionEffect { get; } = 0;
    }
}