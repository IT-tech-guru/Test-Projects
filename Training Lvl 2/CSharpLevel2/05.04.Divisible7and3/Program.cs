using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._04.Divisible7and3
{
    class Program
    {
        static void Main()
        {
            int[] randomNum = new int[1000];
            Random RandomNumber = new Random();
            for (int i = 0; i < 1000; i++)
            {
                randomNum[i] = RandomNumber.Next(1, 1000);
            }

            var selectedNums = randomNum.Where(num => num % 3 == 0 && num % 7 == 0);

            foreach (var num in selectedNums)
            {
                Console.WriteLine(num);
            }
        }
    }    
}
