namespace Infestation
{
    public class Weapon:ISupplement
    {
        private int _powerEffect;
        private int _aggressionEffect;
        private int _healthEffect;
        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                _powerEffect = 10;
                _aggressionEffect = 3;
            }
        }

        public int PowerEffect => _powerEffect;
        public int HealthEffect => _healthEffect;
        public int AggressionEffect => _aggressionEffect;
    }
}