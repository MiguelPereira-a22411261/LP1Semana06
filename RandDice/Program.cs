using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random s = new Random(int.Parse(args[1]));
        }
    }
}
