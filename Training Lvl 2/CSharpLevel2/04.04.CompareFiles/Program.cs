// 4.Write a program that compares two text ﬁles line by line and prints the 
// number of lines that are the same and the number of lines that are different. 
// Assume the ﬁles have equal number of lines.

using System;
using System.IO;

namespace _04._04.CompareFiles
{
    class Program
    {
        static void Main()
        {
            string pathInput1 = "../../../input1.txt";
            string pathInput2 = "../../../input2.txt";

            int diffLines = 0;
            int sameLines = 0;

            using (StreamReader file1 = new StreamReader(pathInput1, true))
            {
                using (StreamReader file2 = new StreamReader(pathInput2, true))
                {
                    while(!file1.EndOfStream || !file2.EndOfStream )
                    {
                        if (file1.ReadLine().CompareTo(file2.ReadLine()) == 0)
                        {
                            sameLines++;
                        }
                        else
                        {
                            diffLines++;
                        }
                    }
                }
            }

            Console.WriteLine($"Different lines: {diffLines}");
            Console.WriteLine($"Same lines: {sameLines}");
        }
    }
}
