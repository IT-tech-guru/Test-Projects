using System;
using System.Linq;

namespace _05._01.AgeBetween
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
            };

            var anonymousObjects = new[]
            {
                new { FirstName = "Dimityr", LastName = "Cvetkov", Age = 17 },
                new { FirstName = "Cvetelina", LastName = "Dimitrova", Age = 45 },
                new { FirstName = "Boris", LastName = "Angelov", Age = 18 },
                new { FirstName = "Angel", LastName = "Borisov", Age = 20 },
            };

            var query =
                from worker in workers
                where worker.Age >= 18 && worker.Age <= 24
                select new { worker.FirstName, worker.LastName };

            var queryLambda = workers
                .Where(worker => worker.Age >= 18 && worker.Age <= 24)
                .Select(worker => new { Worker = worker.FirstName, worker.LastName });

            var queryAnonymous =
                from worker in anonymousObjects
                where worker.Age >= 18 && worker.Age <= 24
                select new { worker.FirstName, worker.LastName };


            Console.WriteLine("Using LINQ:");
            foreach (var item in query)
            {                
                Console.WriteLine(item);                
            }
            Console.WriteLine("\n");

            Console.WriteLine("Using LINQ lambda");
            foreach (var item in queryLambda)
            {                
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Using anonymous objects");
            foreach (var item in queryAnonymous)
            {                
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}
