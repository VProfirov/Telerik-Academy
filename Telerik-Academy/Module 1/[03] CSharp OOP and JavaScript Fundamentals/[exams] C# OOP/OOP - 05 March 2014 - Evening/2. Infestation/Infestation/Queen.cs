namespace Infestation
{
    public class Queen:Unit
    {
        public const int QueenHealth = 30;
        public const int QueenPower = 1;
        public const int QueenAggression = 1;
        public Queen(string id) : base(id, UnitClassification.Psionic, Queen.QueenHealth, Queen.QueenPower, Queen.QueenAggression)
        {
            //TODO: IMPL:
            void InfestingConditions()
            {
                /*
                 •	Infesting has some requirements
o	A Biological unit can only be infested by another Biological unit
o	A Mechanical unit can only be infested by a Psionic unit
o	A Psionic unit can only be infested by another Psionic unit
o	There is some code in the API reflecting these rules, seek it out

                 */
                AddSupplement(new InfestationSpores());
            }

        }
    }
}