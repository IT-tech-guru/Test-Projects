using System;
using System.Linq;

namespace _05._02.OrderByThenBy
{
    class Program
    {
        static void Main()
        {
            var workers = new[]
            {
                new Worker("Ivan", "Ivanov", 15),
                new Worker("Georgi", "Georgiev", 24),
                new Worker { FirstName = "Dimitar", LastName = "Dimitrov", Age = 22},
                new Worker { FirstName = "Atanas", LastName = "Atanasov", Age = 33},            
                new Worker { FirstName = "Atanas", LastName = "Cvetanov", Age = 33},
                new Worker { FirstName = "Atanas", LastName = "Borisov", Age = 33},
                new Worker { FirstName = "Atanas", LastName = "Dobrev", Age = 33},
            };

            var queryLambda1 = workers
                .OrderByDescending(worker => worker.FirstName)
                .ThenByDescending(worker => worker.LastName)
                .ToList();

            Console.WriteLine("Using LINQ lambda");
            foreach (var user in queryLambda1)
            {
                Console.WriteLine($"FirstName: {user.FirstName}, LastName: {user.LastName}, Age: {user.Age}");
            }
            Console.WriteLine("\n");
        }
    }
}
