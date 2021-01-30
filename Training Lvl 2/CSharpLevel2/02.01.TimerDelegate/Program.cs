// 1.Using delegates write a class Timer that has can 
// execute certain method at each t seconds.


using System;
using System.Linq;
using System.Threading;

namespace _02._01.TimerDelegate
{
    class Program
    {     
        static void Main()
        {
            TickerUsingField tickerUsingField = new TickerUsingField(Timer.Action);
            TickerUsingMethod tickerUsingMethod = new TickerUsingMethod(Timer.ConsoleTicker);

            while (true)
            {
                Thread.Sleep(1000);
                //tickerUsingField();
                tickerUsingMethod();                             
            }
        }
    }
}
