/*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 *Print the obtained array on the console.
 */

namespace IntegersByFive
{
    using System;

    class IntegersByFive
    {
        static void Main()
        { 
            // initializing the array with 20 elements
            int[] simpleArray = new int [20];

            // filling the array
            for (int i = 0; i < simpleArray.Length; i++)
            {
                simpleArray[i] = i*5;
            }
            // The better approach -> for accessing every element of an array ((all of it (0 to n-1))step by step)
            foreach (var element in simpleArray)
            {
                Console.WriteLine(element);
            }
            //Standart "for" loop
            //for (int i = 0; i < simpleArray.Length; i++)
            //{
            //    Console.WriteLine(simpleArray[i]);
            //}
        }
    }
}