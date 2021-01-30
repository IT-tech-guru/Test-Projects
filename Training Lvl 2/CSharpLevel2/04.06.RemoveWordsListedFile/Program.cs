// 6.Write a program that removes from a text ﬁle all words listed in given another text ﬁle. 
// Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _04._06.RemoveWordsListedFile
{
    class Program
    {
        List<string> listWords = new List<string>();

        static void Main()
        {
            string pathInput = "../../../input.txt";
            string pathWords = "../../../words.txt";
            string pathOutput = "../../../output.txt";

            try
            {
                var listWords = ExtractWords(pathWords);
                DeleteWordsFromFile(pathInput, pathOutput, listWords);
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine($"Error message: {fnf}");
                throw;
            }

            Console.WriteLine("The input file: \n");
            PrintFileContent(pathInput);

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("The words which will be deleted from the input file: \n");
            PrintFileContent(pathWords);

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Output file after the words listed in the file are deleted: \n");
            PrintFileContent(pathOutput);
        }

        static List<string> ExtractWords (string filePath)
        {
            var listWordsLocal = new List<string>();
            using (StreamReader file = new StreamReader(filePath))
            {
                while (!file.EndOfStream)
                {
                    var words = file
                        .ReadLine()
                        .Split(new char[] { ' ', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!listWordsLocal.Contains(words[i]))
                        { 
                        listWordsLocal.Add(words[i]);
                        }
                    }
                }
            }
            return listWordsLocal;
        }

        static void DeleteWordsFromFile (string filePathInput, string filePathOutput, List<string> listWords)
        {
            using (StreamWriter fileOutput = new StreamWriter(filePathOutput, true))
            {
                using (StreamReader fileInput = new StreamReader(filePathInput, true))
                {
                    while (!fileInput.EndOfStream)
                    { 
                        var line = fileInput.ReadLine();

                        for (int i = 0; i < listWords.Count; i++)
                        {
                            // REGEX: \bword\b
                            line = Regex.Replace(line, "\\b" + listWords[i] + "\\b", string.Empty);
                        }

                        fileOutput.WriteLine(line);
                    }
                }
            }
        }

        static void PrintFileContent(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
