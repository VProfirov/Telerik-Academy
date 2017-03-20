using System;
using System.Linq;
using System.Reflection;
//using System.Linq;
namespace _01.Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            long longue0b = 0b1000_0001;
            long longue = 1000_0001;
            long l = 129;
            string L = Convert.ToString(l,2);

            Console.WriteLine("number: " + l);
            Console.WriteLine("0b: " + longue0b);
            Console.WriteLine("_: " + longue);
            Console.WriteLine("Convert.ToString(_,_): "+ L);
            
        }
    }
}