/*Problem 12.	* Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
Assume that repeating the same subset several times is not a problem. 
* Hint: you may check for zero each of the 32 subsets with 32 if statements.
* Examples:

numbers	        result
3  -2  1  1 8	-2 + 1 + 1 = 0
* 
3 1 -7 35 22	no zero subset
* 
1 3 -4 -2 -1	1 + -1 = 0
1 + 3 + -4 = 0
3 + -2 + -1 = 0
* 
1 1 1 -1 -1	    1 + -1 = 0
1 + 1 + -1 + -1 = 0
1 + -1 + 1 + -1 = 0
…
* 
0 0 0 0 0	    0 + 0 + 0 + 0 + 0 = 0


*/

namespace ZeroSubset
{
    using System;
    using System.Collections.Generic;

    class ZeroSubset
    {
        static void Main()
        {
            const int LEN = 5;
            string pattern;
            int[] a = new int[LEN];

            string[] values = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < LEN; i++)
            {
                a[i] = int.Parse(values[i]);
            }

            int zerosCount = 0, currentSum;
            List<int> numbers;
            for (int i = 1, m = (int)Math.Pow(2, LEN); i < m; i++)
            {
                pattern = Convert.ToString(i, 2).PadLeft(LEN, '0');
                currentSum = 0;
                numbers = new List<int>();
                for (int j = 0; j < LEN; j++)
                {
                    if (pattern[j] == '1')
                    {
                        currentSum += a[j];
                        numbers.Add(a[j]);
                    }
                }
                if (currentSum == 0)
                {
                    zerosCount++;
                    if (numbers.Count > 1)
                    {
                        for (int j = 0; j < numbers.Count - 1; j++)
                        {
                            Console.Write("{0} + ", numbers[j]);
                        }
                        Console.WriteLine("{0} = 0", numbers[numbers.Count - 1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} = 0", numbers[0]);
                    }
                }
            }
            if (zerosCount > 0)
            {
                Console.WriteLine("Total: {0} subset(s), whose sum is 0", zerosCount);
            }
            else
            {
                Console.WriteLine("no zero suset");
            }
        }
    }
}
////NOTES: Another solution (32 ifs)
/*
 Console.WriteLine("Enter five integer numbers");

 int a = int.Parse(Console.ReadLine());
 int b = int.Parse(Console.ReadLine());
 int c = int.Parse(Console.ReadLine());
 int d = int.Parse(Console.ReadLine());
 int e = int.Parse(Console.ReadLine());

 //// before and after each Console.Write line there has to be {} for quality code
 if (a + b == 0)
 Console.WriteLine("{0} + {1} = 0", a, b);
 if (a + c == 0)
 Console.WriteLine("{0} + {1} = 0", a, c);
 if (a + d == 0)
 Console.WriteLine("{0} + {1} = 0", a, d);
 if (a + e == 0)
 Console.WriteLine("{0} + {1} = 0", a, e);
 if (b + c == 0)
 Console.WriteLine("{0} + {1} = 0", b, c);
 if (b + d == 0)
 Console.WriteLine("{0} + {1} = 0", b, d);
 if (b + e == 0)
 Console.WriteLine("{0} + {1} = 0", b, e);
 if (c + d == 0)
 Console.WriteLine("{0} + {1} = 0", c, d);
 if (c + e == 0)
 Console.WriteLine("{0} + {1} = 0", c, e);
 if (d + e == 0)
 Console.WriteLine("{0} + {1} = 0", d, e);
 if (a + b + c == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
 if (a + b + d == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
 if (a + b + e == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
 if (a + c + d == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
 if (a + c + e == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
 if (a + d + e == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
 if (b + c == 0)
 Console.WriteLine("{0} + {1} = 0", b, c);
 if (b + d == 0)
 Console.WriteLine("{0} + {1} = 0", b, d);
 if (b + e == 0)
 Console.WriteLine("{0} + {1} = 0", b, e);
 if (b + c + d == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
 if (b + c + e == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
 if (b + d + e == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
 if (c + d == 0)
 Console.WriteLine("{0} + {1} = 0", c, d);
 if (c + e == 0)
 Console.WriteLine("{0} + {1} = 0", c, e);
 if (c + d + e == 0)
 Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
 if (d + e == 0)
 Console.WriteLine("{0} + {1} = 0", d, e);
 if (a + b + c + d == 0)
 Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
 if (a + b + c + e == 0)
 Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
 if (a + b + d + e == 0)
 Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
 if (a + c + d + e == 0)
 Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
 if (b + c + d + e == 0)
 Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
 if (a + b + c + d + e == 0)
 Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
 else
 Console.WriteLine("no zero subset");

 * 
 * AND A REAL HARDCORE ONE -- when you can't sleep you do stupid things :D :D :D
 * 
        Console.WriteLine("Enter integer number.");
        int numA = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        int numB = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        int numC = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        int numD = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");
        int numE = int.Parse(Console.ReadLine());
        Console.WriteLine("\n");

        bool checkAB = (numA + numB == 0);
        bool checkAC = (numA + numC == 0);

        bool checkABC = (numA + numB + numC == 0);
        bool checkABD = (numA + numB + numD == 0);
        bool checkABE = (numA + numB + numE == 0);

        bool checkABCD = (numA + numB + numC + numD == 0);
        bool checkABCE = (numA + numB + numC + numE == 0);

        bool checkABCDE = ((numA + numB + numC + numD + numE) == 0);

        bool checkBC = (numB + numC == 0);
        bool checkBE = (numB + numE == 0);

        bool checkBEC = (numB + numE + numC == 0);
        bool checkBED = (numB + numE + numD == 0);
        bool checkBCD = (numB + numC + numD == 0);

        bool checkBCAE = (numB + numC + numA + numE == 0);
        bool checkBCDE = (numB + numC + numD + numE == 0);

        bool checkCD = (numC + numD == 0);
        bool checkCE = (numC + numE == 0);

        bool checkCADE = (numC + numA + numD + numE == 0);

        bool checkCAE = (numC + numA + numE == 0);
        bool checkCAD = (numC + numA + numD == 0);

        bool checkDA = (numD + numA == 0);
        bool checkDB = (numD + numB == 0);
        bool checkDE = (numD + numE == 0);

        bool checkDEBA = (numD + numE + numB + numA == 0);

        bool checkEA = (numE + numA == 0);

        bool checkEAC = (numE + numA + numC == 0);
        bool checkEAD = (numE + numA + numD == 0);
        
         if ((checkAB) && (checkABC) && (checkABCD) && (checkABCDE) &&
            (checkABCE) && (checkABD) && (checkABE) && (checkAC) &&
            (checkBC) && (checkBCAE) && (checkBCD) && (checkBCDE) &&
            (checkBE) && (checkBEC) && (checkBED) && (checkCAD) &&
            (checkCADE) && (checkCAE) && (checkCD) && (checkCE) &&
            (checkDA) && (checkDB) && (checkDE) && (checkDEBA) &&
            (checkEA) && (checkEAC) && (checkEAD))
         {
            Console.Write("{0}+{1}+{2}+{3}+{4}=0", numB, numC, numD, numA, numE);
            Console.WriteLine("\n");
            return;
         }
        if (checkAB) 
        {
           Console.Write("{0}+{1}=0", numA, numB);
           Console.WriteLine("\n");
        }
         if (checkAC)
        {
            Console.Write("{0}+{1}=0", numA, numC);
            Console.WriteLine("\n");
        }
        if (checkBC)
        {
            Console.Write("{0}+{1}=0", numB, numC);
            Console.WriteLine("\n");
        }
         if (checkBE)
        {
            Console.Write("{0}+{1}=0", numB, numE);
            Console.WriteLine("\n");
        }
         if (checkCD)
        {
            Console.Write("{0}+{1}=0", numC, numD);
            Console.WriteLine("\n");
        }
         if (checkCE)
        {
            Console.Write("{0}+{1}=0", numC, numE);
            Console.WriteLine("\n");
        }
         if (checkDA) 
        {
            Console.Write("{0}+{1}=0", numD, numA);
            Console.WriteLine("\n");
        }
         if (checkDB)
        {
            Console.Write("{0}+{1}=0", numD, numB);
            Console.WriteLine("\n");
        }
         if (checkDE)
        {
            Console.Write("{0}+{1}=0", numD, numE);
            Console.WriteLine("\n");
        }
         if (checkEA) 
        {
            Console.Write("{0}+{1}=0", numE, numA);
            Console.WriteLine("\n");
        }
         if (checkABC) 
        {
            Console.Write("{0}+{1}+{2}=0", numA, numB,numC);
            Console.WriteLine("\n");
        }
         if (checkABD)
        {
            Console.Write("{0}+{1}+{2}=0", numA, numB, numD);
            Console.WriteLine("\n");
        }
         if (checkABE)
        {
            Console.Write("{0}+{1}+{2}=0", numA, numB,numE);
            Console.WriteLine("\n");
        }
         if (checkBEC) 
        {
            Console.Write("{0}+{1}+{2}=0", numB, numE,numC);
            Console.WriteLine("\n");
        }
         if (checkBED)
        {
            Console.Write("{0}+{1}+{2}=0", numB, numE,numD);
            Console.WriteLine("\n");
        }
         if (checkBCD)
        {
            Console.Write("{0}+{1}+{2}=0", numB, numC, numD);
            Console.WriteLine("\n");
        }
         if (checkCAE) 
        {
            Console.Write("{0}+{1}+{2}=0", numC, numA, numE);
            Console.WriteLine("\n");
        }
          if (checkCAD)
        {
            Console.Write("{0}+{1}+{2}=0", numC, numA, numD);
            Console.WriteLine("\n");
        }
         if (checkEAC)
        {
            Console.Write("{0}+{1}+{2}=0", numE, numA, numC);
            Console.WriteLine("\n");
        }
         if (checkEAD)
        {
            Console.Write("{0}+{1}+{2}=0", numE, numA, numD);
            Console.WriteLine("\n");
        }
         if (checkABCD)
         {
             Console.WriteLine("{0}+{1}+{2}+{3}=0",numA, numB, numC, numD);
             Console.WriteLine("\n");
         }
         if (checkABCE)
	     {
             Console.WriteLine("{0}+{1}+{2}+{3}=0", numA, numB, numC, numE);
             Console.WriteLine("\n");
	     }
         if (checkBCAE)
         {
             Console.WriteLine("{0}+{1}+{2}+{3}=0",numB,numC,numA,numE);
             Console.WriteLine("\n");
         }
         if (checkBCDE)
         {
             Console.WriteLine("{0}+{1}+{2}+{3}=0", numB, numC, numD, numE);
             Console.WriteLine("\n");
         }
         if (checkCADE)
         {
             Console.WriteLine("{0}+{1}+{2}+{3}=0", numC, numD, numA, numE);
             Console.WriteLine("\n");
         }
         if (checkDEBA)
         {
             Console.WriteLine("{0}+{1}+{2}+{3}=0", numD, numE, numB, numA);
             Console.WriteLine("\n");
         }
         if(!((checkAB)||(checkABC)||(checkABCD)||(checkABCDE)||
            (checkABCE)||(checkABD)||(checkABE)||(checkAC)||
            (checkBC)||(checkBCAE)||(checkBCD)||(checkBCDE)||
            (checkBE)||(checkBEC)||(checkBED)||(checkCAD)||
            (checkCADE)||(checkCAE)||(checkCD)||(checkCE)||
            (checkDA)||(checkDB)||(checkDE)||(checkDEBA)||
            (checkEA)||(checkEAC)||(checkEAD)))  
         {
            Console.WriteLine("No zero subset.");
            Console.WriteLine("\n");
         }
 */