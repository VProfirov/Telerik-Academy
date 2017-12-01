using System;
using System.Linq;
using System.Text;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0.Constraints(have in mind) --> 1.INPUT -> 2.OUTPUT -> 3.COMPUTE

            /* TODO: CONSTRAINTS: 
             * - **N** will always be in the range of [2..100000]
             * - in 70 % of the tests **N * *will be below **50 * */

            // TODO: INPUT
            var inputCounter = int.Parse(Console.ReadLine());
            var handsOfCards = new long[inputCounter];

            for (int i = 0; i < handsOfCards.Length; i++)
            {
                handsOfCards[i] = long.Parse(Console.ReadLine());
            }
            
            /* TODO: STATES
             * 4 type of cards -> c d h s
             * a type is of 0-12 cards -> 2-10-J-A
             */
            var cardTypes = "23456789TJQKA";
            var suitTypes = "cdhs";
            var cardsWeHave = new int[52];

            // TODO: COMPUTE: (bit-read <-> 1 -> has)
            long mask = 1;
            for (int hand = 0; hand < handsOfCards.Length; hand++)
            {
                for (int cardIndex = 0; cardIndex < 52; cardIndex++)
                {
                    int check = (int)((handsOfCards[hand] & (mask << cardIndex)) >> cardIndex);
                    cardsWeHave[cardIndex] += check;
                }
            }

            /* TODO: OUTPUTS
             * LINE 1 => (52 cards hand possible)? "Full deck"   : "Wa wa!"
             * LINE 2 => (cardCount !% 2) ?=> ascendingOrder..join(" ")
             * */
            //LINE 1
            var line1 = (cardsWeHave.Count(x => x > 0) == cardsWeHave.Length ? "Full deck" : "Wa wa!");
            Console.WriteLine(line1);

            //LINE 2
            var sbLine2 = new StringBuilder();
            for (int i = 0; i < cardsWeHave.Length; i++)
            {
                if (cardsWeHave[i] % 2 != 0)
                {
                    var typeIndex = i % cardTypes.Length;  // index inside a cycle
                    var suitsIndex = i / cardTypes.Length; // integer cycle (integer devision)
                    sbLine2.Append(cardTypes[typeIndex] + "" + suitTypes[suitsIndex] + " ");
                }
            }
            var line2 = sbLine2.ToString();
            Console.WriteLine(line2);
        }
    }
}
