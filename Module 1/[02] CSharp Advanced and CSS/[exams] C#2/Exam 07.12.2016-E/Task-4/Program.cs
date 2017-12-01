using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Task_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            long exB1 = 0b1111111111111111111111111100000000000000000000000000;
            long exN1 = 4503599560261632;
//            string exS1 = Convert.ToString(exB1, 2);
            long exB2 = 0b0000000000000000000000000011111111111111111111111111;
            long exN2 = 67108863;
//            string exS2 = Convert.ToString(exB2, 2);
            long exN3 = 1;

            var dataSet = new List<long>(){exN1,exN2,exN3};

//            Console.WriteLine($"{exB1} vs {exN1} == {exB1 == exN1}");
//            Console.WriteLine($"{exB2} vs {exN2} == {exB2 == exN2}");

//            Console.WriteLine(Convert.ToString(long.MinValue,2));

            void Tracker()
            {
                long target = exB1;
                long m = 1;
                for (int i = 0; i < 52; i++)
                {
                    var start = Convert.ToString(target, 2);
                    Console.WriteLine($"start : {start}");
                    var cutter = start.Remove(start.Length - 1 - i);
                    Console.WriteLine($"cutter: {cutter}");

                    long result = (target & (m << i)) >> i;
                    Console.WriteLine($"result: {result} at position {i}");
                    // breaks for each BEYOND the border of the number :: border <-> added 0s
                }
            }
//            Tracker();

            long mask = 1;
            var cardsWeHave = new int[52];
            var cards = "23456789TJQKA";
            var suits = "cdhs";
            for (int hand = 0; hand < dataSet.Count; hand++)
            {
                for (int cardIndex = 0; cardIndex < 52; cardIndex++)
                {
                    int check = (int)(dataSet[hand] & (mask << cardIndex) >> cardIndex);
                    cardsWeHave[cardIndex] += check;
                }
            }


        }
    }
}
