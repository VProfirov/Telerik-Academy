/*Write a program that reads two arrays from the console and compares them element by element.
 */

namespace ComaparingArrays
{
    using System;

    class ComaparingArrays
    {
        static void Main()
        {
            Console.WriteLine("This program reads two arrays from the console and compares them");
            Console.WriteLine(" element by element.");
            Console.WriteLine();

            Console.Write("Please enter how many number should have the FIRST ARRAY : ");
            int sizeArrayOne = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Please enter how many number should have the SECOND ARRAY : ");
            int sizeArrayTwo = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // check for negative number or equal to 0 for size of an array
            if ((sizeArrayOne <= 0) || (sizeArrayTwo <= 0))
            {
                Console.WriteLine("Write POSITIVE INTEGERS for size of the ARRAYs !");
                Console.WriteLine();
                Main();
            }

            int[] arrayOne = new int[sizeArrayOne];
            int[] arrayTwo = new int[sizeArrayTwo];

            Console.WriteLine("Enter the elements for the FIRST ARRAY below.");
            for (int i = 0; i < sizeArrayOne; i++)
            {
                Console.Write("Enter element {0} : ", i);
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Enter the elements for the SECOND ARRAY below.");
            for (int i = 0; i < sizeArrayTwo; i++)
            {
                Console.Write("Enter element {0} : ", i);
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            // comparing the SIZE of the arrays

            while ((sizeArrayOne > 0) && (sizeArrayTwo > 0))
            {
                //if the sizeArrayOne is biggger
                if (sizeArrayOne > sizeArrayTwo)
                {
                    for (int i = 0; i < sizeArrayTwo; i++)
                    {
                        if (arrayOne[i] > arrayTwo[i])
                        {
                            Console.WriteLine("Array One [{0}] : {1} > Array Two [{0}] : {2}", i, arrayOne[i], arrayTwo[i]);
                        }
                        else if (arrayOne[i] < arrayTwo[i])
                        {
                            Console.WriteLine("Array One [{0}] : {1} < Array Two [{0}] : {2}", i, arrayOne[i], arrayTwo[i]);
                        }
                        else
                        {
                            Console.WriteLine("Element {0} of the two ARRAYs are equal --> {1}.", i, arrayOne[i]);
                        }
                        Console.WriteLine();
                    }
                    // printing the rest of the elemnts of the bigger array
                    Console.WriteLine("The rest of the elements of Array One are : ");

                    for (int i = sizeArrayTwo; i < sizeArrayOne; i++)
                    {
                        Console.WriteLine(arrayOne[i]);
                    }
                    Console.WriteLine();
                }
                //if the sizeArrayTwo is biggger
                else if (sizeArrayOne < sizeArrayTwo)
                {
                    for (int i = 0; i < sizeArrayOne; i++)
                    {
                        if (arrayOne[i] > arrayTwo[i])
                        {
                            Console.WriteLine("Array One [{0}] : {1} > Array Two [{0}] : {2}", i, arrayOne[i], arrayTwo[i]);
                        }
                        else if (arrayOne[i] < arrayTwo[i])
                        {
                            Console.WriteLine("Array One [{0}] : {1} < Array Two [{0}] : {2}", i, arrayOne[i], arrayTwo[i]);
                        }
                        else
                        {
                            Console.WriteLine("Element {0} of the two ARRAYs are equal --> {1}.", i, arrayOne[i]);
                        }
                        Console.WriteLine();
                    }
                    // printing the rest of the elemnts of the bigger array
                    Console.WriteLine("The rest of the elements of Array Two are : ");

                    for (int i = sizeArrayOne; i < sizeArrayTwo; i++)
                    {
                        Console.WriteLine(arrayTwo[i]);
                    }
                    Console.WriteLine();
                }
                else // sizeArrayOne == sizeArrayTwo
                {
                    for (int i = 0; i < sizeArrayOne; i++)
                    {
                        if (arrayOne[i] > arrayTwo[i])
                        {
                            Console.WriteLine("Array One [{0}] : {1} > Array Two [{0}] : {2}", i, arrayOne[i], arrayTwo[i]);
                        }
                        else if (arrayOne[i] < arrayTwo[i])
                        {
                            Console.WriteLine("Array One [{0}] : {1} < Array Two [{0}] : {2}", i, arrayOne[i], arrayTwo[i]);
                        }
                        else
                        {
                            Console.WriteLine("Elements {0} of the two ARRAYs are equal.", i);
                        }
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}