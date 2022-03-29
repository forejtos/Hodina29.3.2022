using System;
using System.Collections.Generic;
using System.IO;

namespace Task29._3._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("ThreeMenInABoatEnglish.txt");
            string s = input.ReadToEnd();

            char[] separators = new char[] {' ', ',', '.', '*', ':', '“', '”', '_', '-', '[', ']', '\n', '(', ')', ';', '?', '-', '!' };
            var Value = s.Split(separators);
            Dictionary<string, int> wordrepeat = new Dictionary<string, int>();      //dictionary na slova

            for (int i = 0; i < Value.Length; i++)
            {
                if (wordrepeat.ContainsKey(Value[i]))
                {
                    int value = wordrepeat[Value[i]];
                    wordrepeat[Value[i]] = value + 1;
                }
                else
                {
                    wordrepeat.Add(Value[i], 1);
                }
            }
            foreach (KeyValuePair<string, int> wr in wordrepeat)
            {
                Console.WriteLine("----------------------- SLOVA -----------------------");
                Console.WriteLine(wr.Key + " se opakuje " + wr.Value); 
            }
            Console.ReadKey();

        }
    }
}
