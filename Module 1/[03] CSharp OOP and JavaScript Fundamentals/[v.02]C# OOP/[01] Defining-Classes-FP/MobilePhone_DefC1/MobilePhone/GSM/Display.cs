using System;

namespace MobilePhone.GSM
{
    class Display
    {
        private readonly int? size;
        private readonly int? numberOfColors;

        public Display(int? size = null, int? numberOfColors = null)
        {
            this.size = (size == null || size > 0)
                ? size
                : throw new ArgumentException("The SIZE of the Display can be bigger than 0 or not specified(null)");
            this.numberOfColors = (numberOfColors == null || numberOfColors > 0)
                ? numberOfColors
                : throw new ArgumentException(
                    "The NUMBER OF COLORS of the Display can be bigger than 0 or not specified(null)");
        }

        public int? Size => this.size;

        public int? NumberOfColors => this.numberOfColors;

        //TODO: Clarification as an actual functional type this should use readonly fields
        //TODO: Clarification as an specification type, where corrections are possible(scenario conducting orders based on specifications - instead of models)
    }
}