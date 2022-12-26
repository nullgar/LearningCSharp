using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }
            //Great for counters
            //Console.WriteLine("Hello World!");

            int counterVar = 0;
            string text = "";
            while (counterVar < 6)
            {
                //execute your code
                Console.WriteLine("Please press the Enter key to increment the value!");
                text = Console.ReadLine();
                Console.WriteLine(text == "");
                counterVar++;
                
                string checkVar = counterVar < 6 ? $"{counterVar}" : "";

                Console.WriteLine(checkVar);
                Console.WriteLine();
            }
            //Executes code as long as the condition is met

            int counterVar2 = 0;
            do
            {
                //Execute your code
                Console.WriteLine("Hello Do While Loop!");
                counterVar2++;
                Console.WriteLine(counterVar2);
            } while (counterVar2 < 5);
//Executes code as long as the condition is met
        }
    }
}
