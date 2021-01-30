using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04._07.OccurenceWordsFile
{
    class Program
    {
        static Dictionary<string, int> wordOccurences = new Dictionary<string, int>();

        static void Main()
        {
            string pathInput = "../../../input.txt";
            string pathWords = "../../../words.txt";
            string pathOutput = "../../../ouput.txt";

            ExtractWords(pathWords);
            GetWordOccurs(pathInput, pathOutput);

            Console.WriteLine("Input file: \n");
            PrintFile(pathInput);

            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Number of occurences of words from input file: \n");
            PrintFile(pathOutput);
        }

        private static void ExtractWords(string pathWords)
        {
            using (StreamReader reader = new StreamReader(pathWords))
            {
                while (!reader.EndOfStream)
                {
                    string[] words = reader
                        .ReadLine()
                        .Split
                        (
                        new char[] { ' ', ',', '\n' },
                        StringSplitOptions.RemoveEmptyEntries
                        );

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!wordOccurences.ContainsKey(words[i]))
                        {
                            wordOccurences.Add(words[i], 0);
                        }
                    }
                }
            }
        }

        static void GetWordOccurs(string pathText, string pathResult)
        {
            using (StreamWriter output = new StreamWriter(pathResult))
            {
                using (StreamReader input = new StreamReader(pathText))
                {
                    string fileContent = input.ReadToEnd();

                    for (int i = 0; i < wordOccurences.Count; i++)
                    {
                        KeyValuePair<string, int> word = wordOccurences.ElementAt(i);
                        int index = fileContent.IndexOf(word.Key);

                        while (index != -1)
                        {
                            wordOccurences[word.Key]++;
                            index = fileContent.IndexOf(word.Key, index + 1);
                        }
                    }                     
                }

                foreach ( KeyValuePair<string, int> word in wordOccurences.OrderByDescending(key => key.Value) )
                {
                    output.WriteLine($"{word.Key} --> {word.Value} occurences.");
                }
            }
        }

        static void PrintFile(string pathOutput)
        {
            using (StreamReader file = new StreamReader(pathOutput, true))
            {
                Console.WriteLine(file.ReadToEnd());
            }
        }
    }
}
