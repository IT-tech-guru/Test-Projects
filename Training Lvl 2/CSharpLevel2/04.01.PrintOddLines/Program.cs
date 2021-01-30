// 1.Write a program that reads a text ﬁle and prints on the console its odd lines.

using System;
using System.IO;

namespace _04._01.PrintOddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFile = "../../../File.txt";

            Console.WriteLine("Odd lines in a file:\n");

            using (StreamReader reader = new StreamReader(pathFile))
            {
                int lineCount = 1;

                while (!reader.EndOfStream)
               {
                    string line = reader.ReadLine();

                    if (lineCount % 2 != 0)
                    {
                        Console.WriteLine(line);                       
                    }

                    lineCount++;
                }
            }
        }
    }
}
