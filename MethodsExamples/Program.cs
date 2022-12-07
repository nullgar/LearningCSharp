using System;

namespace MethodsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Add(2,3))
            int result = Add(2, 4);
            Console.WriteLine(result);
            int multResult = Multiply(2, 4);
            Console.WriteLine(multResult);
            double divideResult = Divide(2, 4);
            Console.WriteLine(divideResult);
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1/ num2;
        }
    }
}

