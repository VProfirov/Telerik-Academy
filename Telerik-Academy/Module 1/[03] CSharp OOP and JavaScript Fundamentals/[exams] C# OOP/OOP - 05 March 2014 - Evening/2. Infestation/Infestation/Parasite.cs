using System.Collections.Generic;

namespace Infestation
{
    public class Parasite:Unit
    {
        public const int ParasitePower = 1;
        public const int ParasiteAggression = 1;
        public const int ParasiteHealth = 1;

        public Parasite(string id) : base(id, UnitClassification.Biological, Parasite.ParasiteHealth, Parasite.ParasitePower, Parasite.ParasiteAggression)
        {
            AddSupplement(new InfestationSpores());
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            //TODO: IMPL :
            // - attack unit different than THIS
            // - attack unit with least Health (optimalUnit.Health = ^< unit.Health)
            return base.DecideInteraction(units);
        }
    }
}