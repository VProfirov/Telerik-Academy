using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TODO: CONDITIONS: 
             * - **N** will always be in the range of [2..100000]
             * - in 70 % of the tests **N * *will be below **50 * */
            var inputCounter = int.Parse(Console.ReadLine());
            var handsOfCards = new long[inputCounter];

            // TODO: (bit-read <-> 1 is set)
            for (int i = 0; i < handsOfCards.Length; i++)
            {
                handsOfCards[i] = long.Parse(Console.ReadLine());
            }

            /* TODO: 
             * LINE 1 => (52 cards hand possible)? "Full deck"   : "Wa wa!"
             * LINE 2 => (cardCount !% 2) ?=> ascendingOrder..join(" ")
             * */

            /* TODO: STATES
             * 4 type of cards -> c d h s
             * a type is of 0-12 cards -> 2-10-J-A
             */
        }
    }
}
