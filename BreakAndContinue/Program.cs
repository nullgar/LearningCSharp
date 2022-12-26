using System;

namespace BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 11; i++)
            {
                if (i == 9) {
                    Console.WriteLine($"Not this one! {i}");
                    continue;
                }
                if (i % 2 != 0) Console.WriteLine($"This is odd! {i}");

            }
            Console.WriteLine("Hello World!");
        }
    }
}
