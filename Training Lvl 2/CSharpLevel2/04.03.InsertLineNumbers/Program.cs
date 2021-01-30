// 3.Write a program that reads a text ﬁle and inserts line numbers in 
// front of each of its lines. The result should be written to another text ﬁle. .

using System;
using System.IO;

namespace _04._03.InsertLineNumbers
{
    class Program
    {
        static void Main()
        {
            string pathInput = "../../../fileNoLineNumbering.txt";
            string pathOutput = "../../../fileWithLineNumbering.txt";

            ReadFileContent(pathInput, pathOutput);

            PrintResultContent(pathOutput);
        }

        static void ReadFileContent(string pathText, string pathResult)
        {
            using (StreamWriter result = new StreamWriter(pathResult, true))
            {
                using (StreamReader reader = new StreamReader(pathText))
                {
                    var i = 0;

                    while (!reader.EndOfStream)
                    {                        
                        result.WriteLine(i + " " + reader.ReadLine());
                        i++;
                    }
                }
            }
        }

        static void PrintResultContent(string path)
        {
            Console.WriteLine("File with line numbering:\n");

            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream) Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
