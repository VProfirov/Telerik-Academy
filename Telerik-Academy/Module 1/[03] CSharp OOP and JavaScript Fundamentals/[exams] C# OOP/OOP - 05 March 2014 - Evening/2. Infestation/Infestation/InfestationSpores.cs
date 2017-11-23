namespace Infestation
{
    public class InfestationSpores:ISupplement
    {
        private int _powerEffect = -1;
        private int _healthEffect;
        private int _aggressionEffect = 20;
        public void ReactTo(ISupplement otherSupplement)
        {
            //impl : Supplement does not accumulate 
            if (otherSupplement is InfestationSpores)
            {
                _powerEffect = 0;
                _aggressionEffect = 0;
            }
        }

        public int PowerEffect => _powerEffect;
        public int HealthEffect { get; }
        public int AggressionEffect =>_aggressionEffect;
    }
}