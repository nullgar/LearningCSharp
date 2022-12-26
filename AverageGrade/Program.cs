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
            int total = 0;
            Console.WriteLine("Please enter the students grades.");

            while (count < 20)
            {
                int num;
                Console.WriteLine("Please enter a grade from from 0 to 20");
                Console.WriteLine($"Student {count}");
                string val = Console.ReadLine();
                if (int.TryParse(val, out num) && num >= 0 && num <= 20) {
                    total += num;
                    count++;
                } else if (int.TryParse(val, out num) && num == -1) {

                    Console.WriteLine($"The average is {total / count}");
                    break;
                }
                else { Console.WriteLine("That was an invalid value!"); }
                
            }
            return "Complete";
        }
    }
}
