using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_1
{
    class Display
    {
        private readonly double size;

        private readonly int numberOfColors;

        public Display(double size,int numberOfColors)
        {
            object[] valid = Validator(size,numberOfColors);
            this.size = (double)valid[0];
            this.numberOfColors = (int)valid[1];
        }
        public double Size
        {
            get
            {
                return this.size;
            }
           
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
        }

        public object[] Validator(double size,int numberOfColors)
        {
            ////TODO: add validation logic
            object[] validated = { size, numberOfColors };
            return validated;
        }
    }
}
