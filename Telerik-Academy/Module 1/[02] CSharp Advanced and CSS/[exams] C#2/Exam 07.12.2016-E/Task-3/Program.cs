using System;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split('x').Select(int.Parse) as int[];
            var matrix = new char[dimensions[0]][];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            var directions = Console.ReadLine().Split(',').Aggregate((previous,current) => previous + current).ToCharArray();
            var move = string.Empty;
            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case 's': move = "down"; break;
                    case 'w': move = "up"; break;
                    case 'a': move = "left"; break;
                    case 'd': move = "right"; break;
                    default: /*direct move of the stepper in the matrix*/break;
                }
            }

            char step = '\u0000';
            switch (step)
            {
                case '-':
                   break;
                case '%':
                case '@':
                case 'e':
                default:
                  break;
            }
            
        }
    }
}
