using System;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = int.Parse(Console.ReadLine());
            var data = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                data[i] = int.Parse(Console.ReadLine());
            }

            var line1 = Merging(data);
            Console.WriteLine(string.Join(" ", line1));
            var line2 = Squashing(data);
            Console.WriteLine(string.Join(" ", line2));
        }

        public static int[] Merging(int[] data)
        {
            var mergingResult = new int[data.Length - 1];
            var first = 0;
            var second = 0;
            var tmpString = "";
            for (int i = 0; i < data.Length - 1; i++)
            {
                first = (data[i] % 10) * 10;
                tmpString = data[i + 1].ToString();
                second = int.Parse(tmpString.Substring(0, 1));
                mergingResult[i] = first + second;
            }

            return mergingResult;
        }

        public static int[] Squashing(int[] data)
        {
            var squashingResult = new int[data.Length - 1];
            var first = 0;
            var second = 0;
            var tmpString = "";
            var mid = 0;
            for (int i = 0; i < data.Length - 1; i++)
            {
                first = data[i] % 10;
                tmpString = data[i + 1].ToString();
                second = int.Parse(tmpString.Substring(0, 1));
                mid = (first + second) % 10;

                first = data[i] / 10;
                second = int.Parse(tmpString.Remove(0, 1));
                tmpString = first.ToString() + mid + second;
                squashingResult[i] = int.Parse(tmpString);
            }

            return squashingResult;
        }
    }
}
