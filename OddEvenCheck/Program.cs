using System;

namespace OddEvenCheck
{
    internal class Program
    {
        public const int number = 3;

        static void Main(string[] args)
        {
            Console.WriteLine(NumCheck(number));
            Console.Read();
        }

        public static string NumCheck(int number)
        {
            int n = number;
            if (n % 3 == 0)
            {
                return "Divisible by 3.";
            }
            else if (n % 7 == 0)
            {
                return "Divisible by 7.";
            } else
            {
                if (n % 6 != 0)
                {
                    return "Odd number.";
                } else
                {
                    return "Even number.";
                }
            }

            return "Error try again";
        }
    }
}
