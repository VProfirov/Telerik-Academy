using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Sandwich //internal : prompts errors
    {
//        public MeatType MeatType { get; set; }
//        public Mustard Mustard { get; set; }
//        public CheeseType CheeseType { get; set; }
//
//        public EnumIn PropEnumIn { get; set; }

        protected enum EnumIn
        {
            s, q, a
        }


    }

    internal enum MeatType
    {
        chicken, tuna, beef
    }
    enum Mustard
    {
        dijon, regular
    }

    public enum CheeseType
    {
        french, american, bulgarian
    }
}
