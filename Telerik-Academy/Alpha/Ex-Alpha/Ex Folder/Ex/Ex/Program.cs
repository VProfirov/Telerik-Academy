using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = Console.ReadLine();
//            var msg = "Fun exam right";
            var splitMsg = msg.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            bool flag = false;
            do
            {
                for (int i = 0; i < splitMsg.Length; i++)
                {
                    string word = splitMsg[i];
                    if (word.Length == 0)
                    {
                        continue;
                    }
                    sb.Append(word[word.Length - 1].ToString());
                    word = word.Remove(word.Length - 1, 1);
                    splitMsg[i] = word;
                }

                foreach (var word in splitMsg)
                {
                    if (word.Length != 0)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            } while (flag);
            

            var codeMsg = sb.ToString().Trim();

//            Console.WriteLine(codeMsg);

            // 2nd step

            for (int i = 0; i < codeMsg.Length; i++)
            {
                var l = codeMsg[i].ToString();

                char ch = codeMsg[i];

                codeMsg = codeMsg.Remove(i,1);
//                Console.WriteLine("Removed: " + codeMsg);

                int position = i;

                if (ch >= 'a' && ch <= 'z')
                {
                    position += ch - 'a' + 1;
                }
                else if (ch >= 'A' && ch <= 'Z') 
                {
                    position += ch - 'A' + 1;
                }

                              
                position = position % (codeMsg.Length + 1);
                
                
                codeMsg = codeMsg.Insert(position,l);


            }
            Console.WriteLine(codeMsg);

        }
    }
}
