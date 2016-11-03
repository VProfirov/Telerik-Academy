/*
 Problem 8. Isosceles Triangle

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
 */

namespace IsoscelesTriangle
{
    using System;
    // System.Text ,because we are using an Encoding for the copyRight symbol
    using System.Text;

    class IsoscelesTriangle
    {
        static void Main()
        {
            //There is a simple way to complete this task:
            // Use the encoding then output the chars at their direct positions
            // as to form the tasks 4x4x4 triangle, but I decided to make something more interesting
            // and complete the assignment. Now you can decide the size of your Isosceles Triangle. Enjoy.

            //using the Windows Character Map
            //char container = '©';
            //Console.WriteLine(container);

            //using casting approach
            //int containerCasting = 169;
            //Console.WriteLine((char)containerCasting);

            //using char and hexadecimal form
            //char containerHex = '\u00A9';
            //Console.WriteLine(containerHex);

            Console.OutputEncoding = Encoding.Unicode;
            int copyRigt = 169;

            Console.WriteLine("Problem 8 demands 9 \"©\" on 4 rows(side's size of 4) to create Isosceles Triangle");
            Console.WriteLine(",but we gave the option to input any positive integer >= 2 :");
            Console.WriteLine("For the purpose of the problem at hand first test with sides of size 4.");
            Console.Write("Please input your choice [int>=2] in order to create Isosceles Triangle : ");

            int rows = int.Parse(Console.ReadLine());
            //int rows = 4;

            Console.WriteLine();

            // subtracting the empty space from outer-sides
            int substractingBothSides = 0;

            for (int counter = 0; counter < rows - 1; counter++)
            {
                int counterEmptySides = (rows - 1) - counter;
                string emptySpaceSides = new string(' ', counterEmptySides);

                //empty space on the sides - Left
                Console.Write(emptySpaceSides);
                //2st char ©
                Console.Write((char)copyRigt);

                //emptySpaceInner - inner empty space condition
                if (counter == 1)
                {
                    //adding only one empty space, because we add a © - from the 2 subtracted
                    /* in this case because counter is (counter == 1)
                     * we remove this line of code : 
                     
                     int counterEmptyInner = counter + (substractingBothSides); 
                     
                     * because substractingBothsides is 0
                     */
                    string emptySpaceInner = new string(' ', counter);
                    Console.Write(emptySpaceInner);
                }
                else if (counter >= 2)
                {
                    //moving the 2 subtracted outer-sides in using the counter
                    // ()
                    int counterEmptyInner = counter + (substractingBothSides + 1);
                    substractingBothSides++;
                    //printing
                    string emptySpaceInner = new string(' ', counterEmptyInner);
                    Console.Write(emptySpaceInner);
                }
                //else
                //{
                //    string emptySpaceInner = new string(' ', counter);
                //    Console.Write(emptySpaceInner);
                //}

                //2nd char ©
                if (counter > 0)
                {
                    Console.Write((char)copyRigt);
                }

                //empty space on the sides - Right - WriteLine for a new line
                Console.WriteLine(emptySpaceSides);

                // rows - 2 , because 1st we have counter starting from 0 and 2nd time the final row that we are printing
                if (counter == (rows - 2))
                {
                    int cols = rows;
                    // for the purpose of understanding we do this --> int cols = rows , as we are printing now columns of © and empty space
                    //--> but remember : cols - 1 , because rows - 1 , because we are printing this exact last row
                    //again we usually start from the 0th element --> for more info see the NOTES*
                    for (int i = 0; i < cols - 1; i++)
                    {
                        Console.Write((char)copyRigt);
                        Console.Write(" ");
                        // (cols - 2) because we print one more char with a Console.WriteLine --> to end the line
                        if (i == cols - 2)
                        {
                            //Console.WriteLine --> to end the line
                            Console.WriteLine((char)copyRigt);
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

// NOTES: We can always print it line by line, but if we have 1000 lines and little time to print it, then we better try another method
// "if-else" conditional statements : http://msdn.microsoft.com/en-us/library/5011f09h.aspx
// "for" Loops : http://msdn.microsoft.com/en-us/library/ch45axte.aspx