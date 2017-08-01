using System;

namespace TryParseVSParsAssign
{
    using System.ComponentModel;
    using System.Net.Http;

    class Program
    {
        static void Main(string[] args)
        {
            ////            var n1 = ParsingINT("5");
            ////            var n2 = TryParsingINT("b");
            ////n1 < n2
            var track1 = ParsingTrack("Dev");
            var track2 = TryParsingTrack("n");
            if (track1 > track2)
            {
                PrintHi();
            }

            Console.WriteLine(track1);
            Console.WriteLine(track2); ////uses the default* value (0)

            //// Default for Enum is 0 !NOTE the smallest one 
//            Console.WriteLine(n1);
//            Console.WriteLine(n2); ////uses the default* value

//            var v = Convert.GetTypeCode(track1);
//            var v2 = track1.GetType();
//            var v3 = Convert.ChangeType()

            Console.WriteLine(Convert.ToInt32("F", 16));
            //Error difference
//            Console.WriteLine(int.Parse("a"));      //// Format-oriented Error Message
//            Console.WriteLine(Convert.ToInt32("5", 2)); ////Conversion Specific Error Message
        }

        enum Track
        {
            None = -1,
            Front = 0,
            Dev =2
        }

        static Track ParsingTrack(string t)
        {
            return (Track)Enum.Parse(typeof(Track), t);
        }

        static Track TryParsingTrack(string t)
        {
            Track track;
            Enum.TryParse(t, out track);

            return track;
        }

        static bool PrintHi()
        {
            Console.WriteLine("Hello World!");
            return true;
        }

        static int ParsingINT(string i)
        {
            return int.Parse(i);
        }

        static int TryParsingINT(string i)
        {
            int num;
            int.TryParse(i, out num);
            return num;
        }
    }
}