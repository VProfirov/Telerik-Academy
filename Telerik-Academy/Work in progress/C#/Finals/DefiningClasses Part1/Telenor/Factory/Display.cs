using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telenor.Factory
{
    using Telenor.Factory.Utils.Validators;

    class Display
    {
        private readonly int _numberofColors;

        private readonly double _displayInchSize;

        public double DisplayInchSize { get; }

        public int NumberOfColors { get; }

        public Display()
        {
            this.DisplayInchSize = 0.0d;
            this.NumberOfColors = 0;
        }

        public Display(string displaySize, string numberOfColors)
        {
            this.DisplayInchSize = ValidateDisplay.DisplaySize(displaySize);
            this.NumberOfColors = ValidateDisplay.NumberOfColors(numberOfColors);
        }
    }
}
