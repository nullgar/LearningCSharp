using System;

namespace AverageGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CheckInput();
            //Console.WriteLine("Hello World!");
        }

        static string CheckInput( )
        {
            int count = 1;
            double total = 0;
            Console.WriteLine("Please enter the students grades.");
            string val = "0";
            while (val != "-1")
            {
                double num;
                Console.WriteLine("Please enter a grade from from 0 to 20");
                Console.WriteLine($"Student {count}");
                val = Console.ReadLine();
                if (double.TryParse(val, out num) && num >= 0 && num <= 20) {
                    total += num;
                    count++;
                } else if (double.TryParse(val, out num) && num == -1) {

                    Console.WriteLine($"The average is {total / count}");
                    break;
                }
                else { Console.WriteLine("That was an invalid value!"); }
                
            }
            return "Complete";
        }
    }
}
