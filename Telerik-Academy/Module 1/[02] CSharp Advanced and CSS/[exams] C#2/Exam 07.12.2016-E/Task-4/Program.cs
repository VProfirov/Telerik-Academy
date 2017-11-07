using System;

namespace Task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            long exB1 = 0b1111111111111111111111111100000000000000000000000000;
            long exN1 = 4503599560261632;
            string exS1 = Convert.ToString(exB1, 2);
            long exB2 = 0b0000000000000000000000000011111111111111111111111111;
            long exN2 = 67108863;
            string exS2 = Convert.ToString(exB2, 2);

            Console.WriteLine($"{exB1} vs {exN1} == {exB1 == exN1}");
            Console.WriteLine($"{exB2} vs {exN2} == {exB2 == exN2}");

            var res = exN1 + exN2;
        }
    }
}
