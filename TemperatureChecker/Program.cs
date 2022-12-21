using System;
using System.ComponentModel;

namespace TemperatureChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is the current temperature?");
            CheckTemp();

        }


        static void CheckTemp(){
            Console.WriteLine("What is the current temperature?");
            string val = Console.ReadLine();
            int temp;
            if (int.TryParse(val, out temp)) {
                if (temp <= 15) {
                    Console.WriteLine("it is too cold here");
                } else if (temp >= 16 && temp <= 28)
                {
                    Console.WriteLine("it is okay");
                } else if (temp > 28) { 
                    Console.WriteLine("it is hot here");
                }
                Console.WriteLine($"{temp}f");
            } else
            {
                Console.WriteLine("Not a valid Temperature");
            }
        }
    }
}
