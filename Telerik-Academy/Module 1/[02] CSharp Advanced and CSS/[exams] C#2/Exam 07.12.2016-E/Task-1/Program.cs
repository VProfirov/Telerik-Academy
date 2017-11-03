using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);

            var codedDictionary = new Dictionary<string, int>();
            codedDictionary.Add("hristo",0);
            codedDictionary.Add("tosho", 1);
            codedDictionary.Add("pesho",2);
            codedDictionary.Add("hristofor",3);
            codedDictionary.Add("vlad",4);
            codedDictionary.Add("haralampi",5);
            codedDictionary.Add("zoro",6);
            codedDictionary.Add("vladimir",7);

//            codedDictionary = new Dictionary<string,int>(codedDictionary.OrderByDescending(x => x.Key.Length));
            var encodedDic = codedDictionary.OrderByDescending(x => x.Key.Length);
            var product = new BigInteger(1);

            foreach (var encodedNumber in input)
            {
                var octalNumber = new StringBuilder(encodedNumber);
                foreach (var code in encodedDic)
                {
                    octalNumber.Replace(code.Key, code.Value.ToString());
                }
//                Console.WriteLine(septalNumber);
                product *= new BigInteger(Convert.ToInt64(octalNumber.ToString(),8));
            }
            Console.WriteLine(product);
        }
    }
}
