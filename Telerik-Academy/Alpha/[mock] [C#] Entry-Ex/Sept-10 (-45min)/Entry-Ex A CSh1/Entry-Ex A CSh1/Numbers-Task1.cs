using System;
using System.Linq;

namespace Entry_Ex_A_CSh1
{
    public class Numbers_Task1
    {
        public static void Solution_T1()
        {
            var input = Console.ReadLine();
            string strNumber = "";

            while (input != "end")
            {
                var data = input.Split(' ');
                switch (data[0])
                {
                    case "set":
                        strNumber = data[1];
                        break;
                    case "front-add":
                        strNumber = data[1] + strNumber;
                        break;
                    case "front-remove":
                        if (strNumber.Length > 0)
                        {
                            strNumber = strNumber.Remove(0, 1);
                        }
                        break;
                    case "back-add":
                        strNumber = strNumber + data[1];
                        break;
                    case "back-remove":
                        if (strNumber.Length > 0)
                        {
                            strNumber = strNumber.Remove(strNumber.Length - 1);
                        }
                        break;
                    case "reverse":
                        strNumber = string.Concat(strNumber.Reverse());
                        break;
                    case "print":
                        Console.WriteLine(strNumber);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}