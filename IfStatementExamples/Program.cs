using System;

namespace IfStatementExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter the temperature!");
            string ans = Console.ReadLine();
            int temp = int.Parse(ans);
            if (temp < 80)
            {
                Console.WriteLine("It is cold outside!");
            } else if (temp == 80 || temp > 90)
            {
                Console.WriteLine("It is nice outside!");
            } else
            {
                Console.WriteLine("It is hot out!");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
