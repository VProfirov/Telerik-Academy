using System.Collections.Generic;

namespace Infestation
{
    public class Marine:Human
    {
        public Marine(string id) : base(id)
        {
            AddSupplement(new WeaponrySkill());
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            //This method finds the unit with power that is less or equal to the Marine aggression, and highest health, and attacks it
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, 0, 0);

            foreach (var unit in attackableUnits)
            {
                if (unit.Power <= this.Aggression && unit.Health > optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }
    }
}