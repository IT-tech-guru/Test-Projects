using System;
using System.Collections.Generic;
using System.Text;

namespace _03._02.IEnumberable_T
{
    public static class ExtensionSetIEnumebrable
    {
        public static int Count<T>(this IEnumerable<T> collection)
        {
            var count = 0;

            foreach (T item in collection)
            {
                count++;
            }
            return count;
        }

        public static dynamic Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = default(T);

            foreach (T item in collection)
            {
                sum += item;
            }

            return sum;            
        }

        public static dynamic Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = default(T);

            foreach (T item in collection)
            {
                product *= item;
            }

            return product;
        }
        
        public static dynamic Average<T>(this IEnumerable<T> collection)
        {
            return collection.Sum() / collection.Count();
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic min = long.MaxValue;

            foreach (T item in collection)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic max = long.MinValue;

            foreach (T item in collection)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }


    }
}
