using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(250);
            crono1.Stop();
            crono2.Stop();

            TimeSpan cts1 = crono1.Elapsed;
            TimeSpan cts2 = crono2.Elapsed;

            string elapsedTime1 = String.Format("{0:0.0000}", cts1.TotalSeconds);
            string elapsedTime2 = String.Format("{0:0.0000}", cts2.TotalSeconds);

            Console.WriteLine("Crono1: {0} seconds", elapsedTime1);
            Console.WriteLine("Crono2: {0} seconds", elapsedTime2);
        }
    }
}
