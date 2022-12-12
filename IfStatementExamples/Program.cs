using System;

namespace IfStatementExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the temperature!");
            string ans = Console.ReadLine();

            //Okay example below
            //int temp = int.Parse(ans);
            //if (temp < 80)
            //{
            //    Console.WriteLine("It is cold outside!");
            //} else if (temp == 80 || temp > 90)
            //{
            //    Console.WriteLine("It is nice outside!");
            //} else
            //{
            //    Console.WriteLine("It is hot out!");
            //}

            //Better Code Example Below

            int temp;
            int res;
            if (int.TryParse(ans, out res))
            {
                temp = res;
            } else
            {
                temp = -1000;
            }

            if (temp < 80 && temp >= 0)
            {
                Console.WriteLine("It is cold outside!");
            } else if (temp >= 80 && temp <= 90)
            {
                Console.WriteLine("It is nice outside!");
            } else if (temp == -1000 || temp < 0) {
                Console.WriteLine("Entered value was not valid.");
            } else
            {
                Console.WriteLine("It is hot out!");
            }

        }
    }
}
