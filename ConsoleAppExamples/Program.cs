using System;

namespace ConsoleAppExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You entered {0}", readInput);
            //The 0 is replaced by the value of readInput
            Console.ReadKey();


            Console.WriteLine("Enter a string and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("You entered {0}", asciiValue);
            //The 0 is replaced by the value of asciiValue
            Console.ReadKey();
        }
    }
}
