using System;

namespace UserInputExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add());
            Console.Read();
        }

        public static string Add() {
            Console.WriteLine("Let's do some addition. What is the first number?");
            string num1 = Console.ReadLine();
            Console.WriteLine("What is the second number?");
            string num2 = Console.ReadLine();

            string result = $"The total is {int.Parse(num1) + int.Parse(num2)}";
            return result;
        }
    }
}
