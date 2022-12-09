using System;

namespace UserInputExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some addition. What is the first number?");
            string num1 = Console.ReadLine();
            Console.WriteLine("What is the second number?");
            string num2 = Console.ReadLine();

            Console.WriteLine($"The total is {Int64.Parse(num1) + Int64.Parse(num2)}");
            Console.Read();
        }
    }
}
