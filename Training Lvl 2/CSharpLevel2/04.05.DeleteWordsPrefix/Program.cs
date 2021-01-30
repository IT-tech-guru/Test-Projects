// 5.Write a program that deletes from a text ﬁle all words that start with 
// the preﬁx "test". Words contain only the symbols 0...9, a...z, A...Z, _.

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _04._05.DeleteWordsPrefix
{
    class Program
    {
        static void Main()
        {
            string pathInput = "../../../input.txt";
            string pathOutput = "../../../ouput.txt";

            ReaderWriterFiles(pathInput, pathOutput);

            Console.WriteLine("Initial");
            PrintFileContent(pathInput);

            Console.WriteLine("Result from deleting prefixes in a file:\n");
            PrintFileContent(pathOutput);            
        }

        private static void ReaderWriterFiles(string file1, string result)
        {
            using (StreamWriter editedFile = new StreamWriter(result, true))
            {
                using (StreamReader notEditedFile = new StreamReader(file1, true))
                {
                    while (!notEditedFile.EndOfStream)
                    {
                        string line = RemoveWordsStartingWith(notEditedFile);
                        editedFile.Write(line);
                    }
                }
            }

            static string RemoveWordsStartingWith(StreamReader notEditedFile)
            {
                return Regex.Replace(notEditedFile.ReadLine(), @"\btest\S*", string.Empty);
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




