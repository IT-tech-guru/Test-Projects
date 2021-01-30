// 2.Write a program that concatenates two text ﬁles into another text ﬁle.

using System;
using System.IO;

namespace _04._02.FileConcatenation
{
    public class Program
    {
        static void Main()
        {
            string pathFile1 = "../../../file1.txt";
            string pathFile2 = "../../../file2.txt";
            string pathResult = "../../../file1+file2.txt";

            ReadFileContent(pathFile1, pathResult);
            ReadFileContent(pathFile2, pathResult);

            PrintResultContent(pathResult);
        }

        static void ReadFileContent(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult, true))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    while (!reader.EndOfStream) result.WriteLine(reader.ReadLine());
                }
            }
        }

        static void PrintResultContent(string path)
        {
            Console.WriteLine("Result from joining both files:\n");

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
            }
        }
    }
}