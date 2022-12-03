using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Nullgar";
            int age = 10000;
            string job = "Dveloper";

            //String concatenation
            Console.WriteLine("Hello my name is " + name + " and I am " + age + " years old. I work as a " + job + ".");

            //String Formatting
            //Uses index
            Console.WriteLine("Hello my name is {0} and I am {1} years old. I work as a {2}.", name, age, job);

            //String Interpolation
            //Uses the $ symbol to indicate the string is to replace the variable with their assigned value
            Console.WriteLine($"Hello my name is {name} and I am {age} years old. I work as a {job}.");

            //Verbatim Strings
            //Uses the @ symbol and tell the compiler to take the string literally and ignore spaces and escape characters
            //It also ia used for string that has escape characters like \ and even valid escape characters like /n will be ignored
            Console.WriteLine(@"C:/users/nullgar/desktop/coding/");
        }
    }
}
