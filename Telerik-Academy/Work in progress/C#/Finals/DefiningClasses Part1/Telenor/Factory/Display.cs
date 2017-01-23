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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('_', 30));
            sb.AppendFormat("{0}Display Info{0}\r\n",new string(' ',8));
            sb.AppendLine(new string('_', 30));

            sb.AppendLine($"Display's size in inches: {this.DisplayInchSize}");
            sb.AppendLine($"Display's number of colors: {this.NumberOfColors}");

            var message = sb.ToString();
            return message;// to be implemented
        }
    }
}
