/* A dictionary is stored as a sequence of text lines containing words and their explanations.
 * Write a program that enters a word and translates it by using the dictionary. 
 * 
 * Sample dictionary:
 *
 *      .NET – platform for applications from Microsoft
        CLR – managed execution environment for .NET
        namespace – hierarchical organization of classes
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;

public class DictonaryAndExplanation
{
    public static void Main()
    {
        // BOoom

        Dictionary<string, string> explanationDictonary = new Dictionary<string, string>();
        StreamReader reader = new StreamReader("C:\\Users\\Telerik\\Academy\\StringsAndTextProcessing");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] fragedLine = line.Split('-');

                explanationDictonary.Add(fragedLine[0].Trim().ToLower(), fragedLine[1].Trim());
                line = reader.ReadLine();
            }
        }


        string term = Console.ReadLine().Trim().ToLower();
        if (explanationDictonary.ContainsKey(term))
        {
            Console.WriteLine(explanationDictonary[term]);
        }
        else
        {
            Console.WriteLine("No explanation - No explicación - Aucune explication "); // В N на брой часа се решава пропусната задачата
                                                                                        // намерете колко е изтрещял програмиста
                                                                                        // след 10 часа Djangooooooooo
                                                                                        // и принтирайте мислите му в Ordered List !
        }
    }
}
