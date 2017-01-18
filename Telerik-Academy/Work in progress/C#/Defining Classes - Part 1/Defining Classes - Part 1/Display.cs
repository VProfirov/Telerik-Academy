using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Part_1.Utility.Validation;
namespace Defining_Classes___Part_1
{
    class Display
    {
        private readonly double? size;

        private readonly int? numberOfColors;

        public Display(double? size,int? numberColors)
        {
            this.size = size;
            this.numberOfColors = numberColors;
            this.Validation();
            ////better posion then to validate at the end... [as in the EXAM - Is it part of the factory pattern?]
            ////Shouldnt the Validation take the ctor params to check them first ?
        }
        public Display(double? size)/*:this(size, numberColors)*/
        {
            this.size = size;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
           
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
        }
        /// <summary>
        /// Uses utility class that has the Validation - check the Exam
        /// </summary>
        /// <param name="size"></param>
        /// <param name="numberOfColors"></param>
        /// <returns>ArgumentException if Invalid</returns>
        private void Validation()
        {
            ////TODO:#6.Add validation logic in ?one direction? (utity validatio nonly? or + Prop Validation Too)
            Validator.ValidateDisplaySize(this.size);
            Validator.ValidateDisplayNumberOfColors(this.numberOfColors);
            /*
             * if the Method names was Validator (and the class has the same name)
             then : 
                Utility.Validation.Validator.ValidateDisplayNumberOfColors(this.numberOfColors);
             is needed in order to negate embiguity with the name calling
             */

        }
        public override string ToString()
        {
            StringBuilder endText = new StringBuilder();
            endText.AppendLine("---------Display --------");
            endText.AppendLine(this.size.ToString());
            endText.AppendLine(this.numberOfColors.ToString());
            return endText.ToString();
        }
    }
}
