// 2.Implement a set of extension methods for IEnumerable<T> that implement 
// the following group functions: sum, product, min, max, average.


using System;
using System.Collections.Generic;


namespace _03._02.IEnumberable_T
{
    class Program
    {
        static void Main()
        {
            var listIntegers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var arrayIntegers = new int[] { 1, 23, 4, 5, 5, 5 };

            PrintCollection(listIntegers);
            PrintCollection(arrayIntegers);
        }

        private static void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.WriteLine($"Actual elements from collection: {string.Join(", ", collection)}");
            Console.WriteLine($"Sum: {collection.Sum()}");
            Console.WriteLine($"Product: {collection.Product()}");
            Console.WriteLine($"Min: {collection.Min()}");
            Console.WriteLine($"Max: {collection.Max()}");
            Console.WriteLine($"Average: {collection.Average()}");
            Console.WriteLine("\n");
        }
    }
}
