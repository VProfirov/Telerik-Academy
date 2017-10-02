using System;
using System.IO;

namespace WR
{
    class Program
    {
        static void Main(string[] args)
        {
            void SR()
            {
                string line = string.Empty;
                using (var sr = new StreamReader("TextFile.txt"))
                {
                    line = sr.ReadLine();
                    line += " is read";

                }

                using (var sw = new StreamWriter("TextFile.txt"))
                {
                    sw.WriteLine(line);
                }
            }

            var lineR = string.Empty;
            using (TextReader reader = File.OpenText("TextFile.txt"))
            {
                lineR = reader.ReadToEnd();
                lineR = lineR.Trim();
                Console.WriteLine(lineR);
            }
            using (TextWriter writer = File.CreateText("TextFile.txt"))
            {
                writer.WriteLine("hubahuba");
                Console.WriteLine(lineR);
            }
        }
    }
}
