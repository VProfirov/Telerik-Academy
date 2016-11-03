/*Problem 2.	Gravitation on the Moon
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:

weight	weight on the Moon
86	    14.62
74.6	12.682
53.7	9.129
 */

namespace GravitationOnTheMoon
{
    using System;

    class GravitationOnTheMoon
    {
        static void Main()
        {
            double earthWeight;

            Console.Write("Write the weight of a man on Earth as a integer : ");
            bool vaildEarthWeight = double.TryParse(Console.ReadLine(), out earthWeight);

            double moonWeight;

            if (vaildEarthWeight)
            {
                // NB! Your console might use (xx,xx), even that in the Visual Studio you use (xx.xx)
                // examples 74,6 input in the console -> but 0.17 in Visual Studio
                // can be fixed by fixing the encoding if needed - bare that in mind on the future exams !

                moonWeight = earthWeight * 0.17;
                Console.Write("His/her weight on the Moon is : {0}",moonWeight);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Enter a valid integer for a weight of the man ! Try again.");
                Main();
            }

        }
    }
}

//NOTES :

// NB! = NOTA BENE - important note ; "note well"

// 74,6 input in the console -> output on the console 12,682 -> but 0.17 (for the 17%) in Visual Studio

/* IMPORTANT --> the TryParse check with calling the Main() method when the validation is false
will not be performed in the next exercises if it is not explicitly demanded a check of the input values
or example values are not given */