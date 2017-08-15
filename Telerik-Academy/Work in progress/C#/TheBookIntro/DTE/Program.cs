using System;
using System.Collections.Generic;
using System.Text;

namespace DTE
{
    public enum Track
    {
        None = 0,
        Dev = 1,
        Front = 2
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //Case2("TheBookIntro.Track", "Dev");

            Console.WriteLine(typeof(Track));
            Console.WriteLine();
        }

        public static void Case2(string en, string track)
        {
            Type t = Type.GetType(en);
            //Console.WriteLine("TYPE: " + t);

            Track vT;
            Enum.TryParse(track, out vT);
            //var vT = (Type)Enum.Parse(t, track);
            Console.WriteLine(vT);

            var validTrack = (Track)Enum.Parse(typeof(Track), track);
            //Console.WriteLine(validTrack);
            //return validTrack;
        }

        public static void CaseOne()
        {
            var track = "dede";
            var track2 = "dev";
            var track3 = "Dev";

            Track t;

            Enum.TryParse<Track>(track2, true, out t);

            Console.WriteLine(t);
        }
    }
}
