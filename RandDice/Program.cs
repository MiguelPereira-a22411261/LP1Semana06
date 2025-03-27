using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random s = new Random(int.Parse(args[1]));
            int add = 0;

            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                add += s.Next(1, 7);
            }
            Console.WriteLine(add);

        }
    }
}
