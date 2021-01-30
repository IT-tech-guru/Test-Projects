using System;
using System.Collections.Generic;
using System.Text;

namespace _05._02.OrderByThenBy
{
    public class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Worker()
        {

        }

        public Worker(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
