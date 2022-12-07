using System;

namespace GreetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Freind, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine(Greet(name));
            Console.Read();
        }

        static string Greet(string name)
        {
            return $"Hello {name}!";
        }
    }
}
