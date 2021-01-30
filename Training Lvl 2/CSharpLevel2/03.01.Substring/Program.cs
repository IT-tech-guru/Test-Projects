// 1.Implement an extension method Substring
// (int index, int length) for the class StringBuilder that
// returns new StringBuilder and has the same functionality 
// as Substring in the class String.

using System;
using System.Text;

namespace _03._01.Substring
{
    class Program
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.Append("This is some experimental text appended");
            text.Append("Some more text");

            Console.WriteLine($"1. {text.Substring(1)}");
            Console.WriteLine($"1. {text.Substring(3)}");
            Console.WriteLine($"1. {text.Substring(2, 5)}");
            Console.WriteLine($"1. {text.Substring(4, 4)}");
        }
    }
}
