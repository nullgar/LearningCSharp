using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, would you like a dring?");
            Console.WriteLine("What is your age?");
            int age;

            try {
                age = int.Parse(Console.ReadLine());
                switch (age)
                {
                    case int when age < 21:
                        Console.WriteLine();
                        Console.WriteLine("You cannot have a drink, you are to young!");
                        break;
                    case int when age <= 21:
                        Console.WriteLine();
                        Console.WriteLine("Perfect have a drink!");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("You must enter a valid value!");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid value!");
            }
            

          
        }
    }
}
