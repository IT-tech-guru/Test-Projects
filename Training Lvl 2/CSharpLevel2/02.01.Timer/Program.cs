using System;
using System.Linq;
using System.Threading;

namespace _02._01.Timer
{
    class Program
    {
        static void Main()
        {
            var ticker = new Ticker(Timer.Action); // delegate -> action

            while (true)
            {
                Thread.Sleep(1000);
                ticker();
            }
        }
    }
}
