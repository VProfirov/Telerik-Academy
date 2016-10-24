/*Problem 16.	** Bit Exchange (Advanced)
Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
The first and the second sequence of bits may not overlap.
 Examples:
 
n	        p	q	k	binary representation of n	            binary result	                         result
1140867093	3	24	3	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
4294901775	24	3	3	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
2369124121	2	22	10	10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001	    1907751121
987654321	2	8	11	-		                                 -                                       overlapping
123456789	26	0	7	-		                                 -                                       out of range
33333333333	-1	0	33	-		                                 -                                       out of range

 */

namespace BitExchangeAdvanced
{
    using System;

    class BitExchangeAdvanced
    {
        static void Main()
        {
            Console.Write("n = ");
            long n = long.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
 
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
 
            if (p + k >= 32)
            {
                Console.WriteLine("Out of range");
            }
            else if (p < q && ((p + q) < k))
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    int maskOne = (int)(n & (1 << p)) >> p;
                    int maskTwo = (int)(n & (1 << q)) >> q;

                    //mask one
                    if (maskOne == 0)
                    {
                        n = n & (~(1 << q));
                    }
                    else if (maskOne == 1)
                    {
                        n = n | (1 << q);
                    }

                    //mask two
                    if (maskTwo == 0)
                    {
                        n = n & (~(1 << p));
                    }
                    else if (maskTwo == 1)
                    {
                        n = n | (1 << p);
                    }

                    p++;
                    q++;
                }

                Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
                Console.WriteLine(n);
            }
        }
    }
}

// NOTES: Try catch + change to unsigned integer

/*
            int number = 37240;
            byte p = 2;
            byte q = 9;
            byte k = 2;

            Console.WriteLine("The number (example) is {0}", number);

            // Turning the number in bin system
            int[] numberInBin = new int[32];
            for (int i = 0; i < numberInBin.Length; i++)
            {
                if (number == 0)
                {
                    break;
                }
                numberInBin[i] = number % 2;
                number = number / 2;
            }
            // Printing the list
            Console.WriteLine("Printing the list of byte type of the number. ");
            for (int i = 0; i < numberInBin.Length; i++)
            {
                Console.Write(numberInBin[i]);
            }
            Console.WriteLine();
            //Making the change
            Console.WriteLine("Making the change.");
            for (int i = 0; i < k; i++)
            {
                int temp = 0;
                temp = numberInBin[p];
                numberInBin[p] = numberInBin[q];
                numberInBin[q] = temp;
                p++;
                q++;
            }
            // Printing the final edited list
            //numberInBin.Reverse();
            Array.Reverse(numberInBin);
            for (int i = 0; i < numberInBin.Length; i++)
            {
                Console.Write(numberInBin[i]);
            }
            Console.WriteLine();
 */