using System;

namespace FirstCSharpProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;
            int num2 = 20;
            // declaring multiple variables at once
            int num3, num4, num5;
            //assigning a value to a variable or initializing the variable
            num1 = 13;

            int sum = num1 + num2;
            //Console.WriteLine(num1);
            Console.WriteLine(sum);
            // You can also use concatination
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);
            // WriteLine is smart enough to convers an int to a string to use concatination
            Console.WriteLine("sum is " + sum);


            double d1 = 3.1415;
            double d2 = 5.1;

            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            // Floating point values are not as precise so the result it cut off
            Console.WriteLine("f1/f2 is " + f1/f2);

            long myLongNum = 1000000000000000000;
            Console.WriteLine("My long num is " + myLongNum);
            Console.Read();
        }
    }
}
