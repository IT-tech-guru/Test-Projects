// 1.Write a program that counts in a given array of 
// double values the number of occurrences of each value. 
// Use Dictionary<TKey, TValue>.
   
   
// Example: array = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
// -2.5-> 2 times
// 3-> 4 times
// 4-> 3 times


using System;
using System.Collections.Generic;

namespace _01._01.NumberOfOccurences
{
    class Program
    {
        static void Main()
        {
            double[] arrayDouble = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            IDictionary<double, int> doubleDict  = new SortedDictionary<double, int>();

            CountOccurences(arrayDouble, doubleDict);
        }

        private static void CountOccurences(double[] arrayDouble, IDictionary<double, int> doubleDict)
        {
            foreach (var doubleNumber in arrayDouble)
            {
                int count = 1;
                if (doubleDict.ContainsKey(doubleNumber))
                {
                    count = doubleDict[doubleNumber] + 1;
                }
                doubleDict[doubleNumber] = count;
            }

            foreach (var pair in doubleDict)
            {
                Console.WriteLine($"{pair.Key} --> {pair.Value}");
            }
        }
    }
}
