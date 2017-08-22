using System;
using System.Collections.Generic;
using System.Text;
namespace ExtensionMethods
{
    using System.Linq;

    public interface ITopology
    {
    }

    public static class InterfaceExtensions
    {
        public static void CountNodes(this ITopology topology)
        {
            // ...
        }
    }

    public static class TypeExtensions
    {
        public static int WordCount(this string text)
        {
            return text.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Length;
        }
        
        public static int LocalFunction(int num)
        {
            //poor example
            int SomeInMethod(int someN)
            {
                return num + someN;
            }

            return SomeInMethod(5);
        }
    }
    
    public class Program
    {
        public static void Main()
        {
            var someText = "Helloo bananas baaaaa na na";
            var count = someText.WordCount();
            Console.WriteLine(count);
        }
    }
}
