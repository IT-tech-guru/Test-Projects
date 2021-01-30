// 2.  * Read in MSDN about the keyword event in C# and
// publish events. Re-implement the above using .NET events and
// following the best practices


using System;
using System.Threading;

namespace _02._02.PublishEvents
{
    class Program
    {

        static event EventHandler<ConsoleKey> HandleEnter;

        public static void CaptureEnterKeyPressed (ConsoleKey key)
        {
            if (key == ConsoleKey.Enter)
            {
                HandleEnter(null, ConsoleKey.Enter);
            }
        }

        static void HandleEnterKeyPress (object sender, ConsoleKey key)
        {
            Console.Clear();
            Timer.Seconds = 0;
        }

        static void TimerActivation(object sender, ConsoleKey key)
        {
            Console.WriteLine("Press [Enter] to reset the timer");

            var action = Timer.Action;

            while (!Console.KeyAvailable || Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Thread.Sleep(300);
                action();
            }
        }


        static void Main()
        {
            Console.WriteLine("Press [Enter] to start");

            HandleEnter += HandleEnterKeyPress;

            HandleEnter += TimerActivation;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    CaptureEnterKeyPressed(Console.ReadKey().Key);
                }
            }

        }
    }
}
