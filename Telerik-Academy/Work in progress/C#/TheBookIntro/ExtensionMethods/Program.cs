using System;
using System.Collections.Generic;
using System.Text;
namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 2;
            
            int Add(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine("The number is " + Add(1,2));
        }
    }

    public static class MyExtensions
    {
        public static int WordCount(this string text)
        {
            return 0;
        }

        public static int NumMethod(int num)
        {
            int SomeInMethod()
            {
                return 0;
            }

            return SomeInMethod();
        }
    }
}
