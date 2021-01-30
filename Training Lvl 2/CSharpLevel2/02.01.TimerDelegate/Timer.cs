using System;
using System.Linq;

namespace _02._01.TimerDelegate
{
    public delegate void TickerUsingField();
    public delegate void TickerUsingMethod();
    public static class Timer
    {
        public static readonly Action Action = new Action(() => Console.WriteLine(++Seconds));

        public static void ConsoleTicker()
        {
            Console.WriteLine(Seconds += 2);
        }

        public static int Seconds { get; private set; }
    }
}