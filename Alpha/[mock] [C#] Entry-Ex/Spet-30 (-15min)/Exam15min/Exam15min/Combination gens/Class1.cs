using System;

namespace TheD
{
    public class Class1
    {
        public static void S2_1()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < Math.Pow(n, k); i++)
            {
                int conv = i;
                int[] num = new int[k];
                for (int j = 0; j < k; j++)
                {
                    num[j] = conv % n;
                    conv = conv / n;
                }

                bool areIncreasing = true;

                for (int m = 0; m < k - 1; m++)
                {
                    if (num[m] > num[m + 1] || num[m] == num[m + 1])
                    {
                        areIncreasing = false;
                    }
                }

                if (areIncreasing)
                {
                    Console.Write("{0}{1}", '{', num[0] + 1);
                    for (int j = 1; j < k; j++)
                    {
                        Console.Write(", {0}", num[j] + 1);
                    }
                    Console.WriteLine("}");
                }
            }
        }
    }
}