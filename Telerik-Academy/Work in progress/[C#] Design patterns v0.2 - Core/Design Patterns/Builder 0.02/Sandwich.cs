using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Builder_0._02
{
    public class Sandwich //internal : prompts errors
    {
        public MeatType MeatType { get; set; }
        public MustardType MustardType { get; set; }
        public CheeseType CheeseType { get; set; }


        public void Display()
        {
            Console.WriteLine($"MeatType : {MeatType}");
            Console.WriteLine($"MustardType : {MustardType}");
            Console.WriteLine($"CheeseType : {CheeseType}");
        }

    }

    public enum MeatType
    {
        chicken,tuna,beef
    }
    public enum MustardType
    {
        dijon, regular
    }

    public enum CheeseType
    {
        french,american,bulgarian
    }

   
}