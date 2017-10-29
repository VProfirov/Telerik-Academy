using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Loops_and_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            ///There is always a catch in the Main as a last method
            try
            {
                Console.WriteLine("1st try");
                throw new Exception();
            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Exception 1 thrown");
//                Console.WriteLine(e);
//                throw;
//            }
            finally
            {
                Console.WriteLine("before return");
                Console.WriteLine(Throwing());
            }
        }

        public static int Throwing()
        {
            try
            {
                Console.WriteLine("2nd try");
//                throw new ArgumentException();

//                var d = new Dictionary<string, int>();
//                d.Add(null,5);
                Console.WriteLine("after throw");
                return 5;
            }
            // no catch no finally
//            catch(Exception e)
//            {
//                Console.WriteLine("2nd catch");
//                Console.WriteLine(e);
//            }
            finally
            {
                Console.WriteLine("Where is 5");
            }
            return 55;
        }
    }
}
